using AutoMapper;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Bl.Mapping;
using ExaLearn.Bl.Services;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Moq;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ExaLearn.Tests.Services
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly Mock<IHistoryRepository> _mockHistoryRepository;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserServiceTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _mockUserRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                .Returns(async () =>
                {
                    return await new Task<User>(() => new User() { Email = "adminexa@mailnesia.com" });
                });

            _mockHistoryRepository = new Mock<IHistoryRepository>();
            _mockHistoryRepository.Setup(x => x.GetUserHistoryByIdAsync(It.IsAny<int>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew<IList<History>>(() => new List<History>()
                    {
                        new History
                        {
                            Id = 1,
                            PassedTest = new PassedTest()
                            {
                                Assessment = 50,
                                PassedTestDate = DateTime.Now
                            },
                            User = new User ()
                            {
                                LevelType = LevelType.Beginner
                            }
                        },
                        new History
                        {
                            Id = 2,
                            PassedTest = new PassedTest()
                            {
                                Assessment = 100,
                                PassedTestDate = DateTime.Now
                            },
                            User = new User ()
                            {
                                LevelType = LevelType.Elementary
                            }
                        }
                    });
                });
            _mockHistoryRepository.Setup(x => x.GetHrUserHistoryByIdAsync(It.IsAny<int>()))
                .Returns(async () =>
                {
                    return await Task.Factory.StartNew<IList<PassedTest>>(() => new List<PassedTest>()
                    {
                            new PassedTest
                            {
                                Id = 1,
                                User =  new  User()
                                {
                                    FirstName = "Aaron",
                                    LastName = "Ramsdale",
                                }
                            },
                            new PassedTest
                            {
                                Id = 2,
                                User =  new  User()
                                {
                                    FirstName = "Sam",
                                    LastName = "Johnstone",
                                }
                            }
                    });
                });

            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

            _userService = new UserService(_mockUserRepository.Object, _mockHistoryRepository.Object, _mapper);
        }

        [Fact]
        public async Task GetUserHistoryByIdAsync_HistoryModelIsValid()
        {
            // Arrange
            var history = _mockUserRepository.Object.GetByIdAsync(1);

            // Act
            var result = await _userService.GetUserHistoryByIdAsync(history.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(50, result[0].Mark);
            Assert.Equal(LevelType.Beginner, result[0].Level);
            Assert.Equal(100, result[1].Mark);
            Assert.Equal(LevelType.Elementary, result[1].Level);
        }

        [Fact]
        public async Task GetHrUserHistoryByIdAsync_HrHistoryModelIsValid()
        {
            // Arrange
            var history = _mockUserRepository.Object.GetByIdAsync(1);

            // Act
            var result = await _userService.GetHrUserHistoryByIdAsync(history.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Aaron Ramsdale", result[0].FullName);
            Assert.Equal("Sam Johnstone", result[1].FullName);
        }
    }
}
