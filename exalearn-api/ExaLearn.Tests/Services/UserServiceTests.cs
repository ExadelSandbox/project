using AutoMapper;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Tests.Fixtures;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ExaLearn.Tests.Services
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly Mock<IHistoryRepository> _mockHistoryRepository;
        private readonly Mock<IMapper> _mockMapper;

        public UserServiceTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _mockUserRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>())).Returns(UserServiceFixture.GetIdAsync());

            _mockHistoryRepository = new Mock<IHistoryRepository>();
            _mockHistoryRepository.Setup(x => x.GetUserHistoryByIdAsync(It.IsAny<int>())).Returns(UserServiceFixture.GetUserHistoryIdAsync());

            _mockMapper = new Mock<IMapper>();
        }

        [Fact]
        public async Task GetUserHistoryByIdAsync_HistoryModelIsValid()
        {
            // Arrange
            var _service = new UserService(_mockUserRepository.Object, _mockHistoryRepository.Object, _mockMapper.Object);
            var historyModel = new History() { Id = 1, PassedTestId = 1, UserId = 1 };
            // Act
            var result = await _service.GetByIdAsync(historyModel.Id);

            // Assert
            Assert.NotNull(result);
        }
    }
}
