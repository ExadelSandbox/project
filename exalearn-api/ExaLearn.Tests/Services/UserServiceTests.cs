using System.Collections.Generic;
using AutoMapper;
using ExaLearn.Bl.Mapping;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Tests.Fixtures;
using Moq;
using System.Threading.Tasks;
using ExaLearn.Dal.Entities;
using Xunit;

namespace ExaLearn.Tests.Services
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly Mock<IHistoryRepository> _mockHistoryRepository;
        private readonly IMapper _mapper;

        public UserServiceTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _mockUserRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>())).Returns(UserServiceFixture.GetIdAsync());

            _mockHistoryRepository = new Mock<IHistoryRepository>();
            _mockHistoryRepository.Setup(x => x.GetUserHistoryByIdAsync(It.IsAny<int>()))
                .Returns(()=>
                {
                    return new Task<IList<History>>(() =>  new List<History>());
                });

            _mockHistoryRepository.Setup(x => x.GetHrUserHistoryByIdAsync(It.IsAny<int>())).Returns(UserServiceFixture.GetHrHistoryAsync());

            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();
        }

        [Fact]
        public async Task GetUserHistoryByIdAsync_HistoryModelIsValid()
        {
            // Arrange
            var service = new UserService(_mockUserRepository.Object, _mockHistoryRepository.Object, _mapper);
            var hrHistory = UserServiceFixture.GetHrHistoryAsync();
            // Act
            var result = await service.GetUserHistoryByIdAsync(hrHistory.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(50, result[0].Mark);
        }

        [Fact]
        public async Task GetHrUserHistoryByIdAsync_HrHistoryModelIsValid()
        {
            // Arrange
            var service = new UserService(_mockUserRepository.Object, _mockHistoryRepository.Object, _mapper);
            var history = UserServiceFixture.GetListHistoryAsync();
            // Act
            var result = await service.GetHrUserHistoryByIdAsync(history.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("firstNamelastName", result[0].FullName);
        }
    }
}
