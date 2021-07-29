using AutoMapper;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Tests.Fixtures;
using Moq;
using System.Collections.Generic;
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
            _mockMapper = new Mock<IMapper>();

            _mockUserRepository = new Mock<IUserRepository>();
            _mockUserRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>())).Returns(UserServiceFixture.GetIdAsync());
            //_mockUserRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
            //    .Returns(async () =>
            //    {
            //        return await new Task<User>(() => new User() { Email = "adminexa@mailnesia.com" });
            //    });

            _mockHistoryRepository = new Mock<IHistoryRepository>();
            _mockHistoryRepository.Setup(x => x.GetUserHistoryByIdAsync(It.IsAny<int>()))
                .Returns(async () =>
                {
                    return await new Task<List<History>>(() => new List<History>()
                    {
                        new History
                        {
                            Id = 1,
                            PassedTest = new PassedTest()
                            {
                                Assessment = 50
                            }
                        },
                    });
                });
            _mockHistoryRepository.Setup(x => x.GetHrUserHistoryByIdAsync(It.IsAny<int>()))
                .Returns(async () =>
                {
                    return await new Task<List<PassedTest>>(() => new List<PassedTest>() {
                            new PassedTest {
                            Id = 1,
                            User =  new  User() {
                                FirstName = "firstName",
                                LastName = "lastName",
                            }
                        }
                    });
                });
        }

        [Fact]
        public async Task GetUserHistoryByIdAsync_HistoryModelIsValid()
        {
            // Arrange
            IUserService _userService = new UserService(_mockUserRepository.Object, _mockHistoryRepository.Object, _mockMapper.Object);
            var history = UserServiceFixture.GetIdAsync();
            // Act
            var result = await _userService.GetUserHistoryByIdAsync(history.);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(50, result[0].Mark);
        }

        [Fact]
        public async Task GetHrUserHistoryByIdAsync_HrHistoryModelIsValid()
        {
            // Arrange
            IUserService _userService = new UserService(_mockUserRepository.Object, _mockHistoryRepository.Object, _mockMapper.Object);
            var history = UserServiceFixture.GetIdAsync();
            // Act
            var result = await _userService.GetHrUserHistoryByIdAsync(history.Id);
            // Assert
            Assert.NotNull(result);
            Assert.Equal("firstNamelastName", result[0].FullName);
        }
    }
}
