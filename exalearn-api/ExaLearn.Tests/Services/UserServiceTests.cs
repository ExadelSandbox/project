//using AutoMapper;
//using ExaLearn.Bl.Interfaces;
//using ExaLearn.Bl.Mapping;
//using ExaLearn.Bl.Services;
//using ExaLearn.Dal.Entities;
//using ExaLearn.Dal.Interfaces;
//using Moq;
//using Shared.Enums;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Xunit;

//namespace ExaLearn.Tests.Services
//{
//    public class UserServiceTests
//    {
//        private readonly Mock<IUserRepository> _mockUserRepository;
//        private readonly Mock<IHistoryRepository> _mockHistoryRepository;
//        private readonly Mock<IAssignTestRepository> _mockAssignTestRepository;
//        private readonly IMapper _mapper;
//        private readonly IUserService _userService;

//        public UserServiceTests()
//        {
//            _mockUserRepository = new Mock<IUserRepository>();

//            _mockHistoryRepository = new Mock<IHistoryRepository>();
//            _mockHistoryRepository.Setup(x => x.GetUserHistoryByIdAsync(It.IsAny<int>()))
//                .Returns(async () =>
//                {
//                    return await Task.Factory.StartNew<IList<History>>(() => new List<History>()
//                    {
//                        new History
//                        {
//                            Id = 1,
//                            PassedTest = new PassedTest()
//                            {
//                                Assessment = 50,
//                                PassedTestDate = DateTime.Now
//                            },
//                            User = new User ()
//                            {
//                                LevelType = LevelType.Beginner
//                            }
//                        },
//                        new History
//                        {
//                            Id = 2,
//                            PassedTest = new PassedTest()
//                            {
//                                Assessment = 100,
//                                PassedTestDate = DateTime.Now
//                            },
//                            User = new User ()
//                            {
//                                LevelType = LevelType.Elementary
//                            }
//                        }
//                    });
//                });
//            _mockHistoryRepository.Setup(x => x.GetHrUserHistoryByIdAsync(It.IsAny<int>()))
//                .Returns(async () =>
//                {
//                    return await Task.Factory.StartNew<IList<PassedTest>>(() => new List<PassedTest>()
//                    {
//                        new PassedTest
//                        {
//                            Id = 1,
//                            User = new  User()
//                            {
//                                FirstName = "Aaron",
//                                LastName = "Ramsdale",
//                            }
//                        },
//                        new PassedTest
//                        {
//                            Id = 2,
//                            User =  new  User()
//                            {
//                                FirstName = "Sam",
//                                LastName = "Johnstone",
//                            }
//                        }
//                    });
//                });
            
//            _mockAssignTestRepository = new Mock<IAssignTestRepository>();
//            _mockAssignTestRepository.Setup(x => x.GetHrAssignedTestByIdAsync(It.IsAny<int>()))
//                .Returns(async () =>
//                {
//                    return await Task.Factory.StartNew<IList<AssignTest>>(() => new List<AssignTest>()
//                    {
//                        new AssignTest
//                        {
//                            Id = 1,
//                            LevelType = LevelType.Beginner,
//                            ExpirationDate = DateTime.Now.AddHours(3),
//                            Assigner = new User
//                            {
//                                FirstName = "Bob",
//                                LastName = "Holland"
//                            }
//                        },
//                        new AssignTest
//                        {
//                            Id = 2,
//                            LevelType = LevelType.Intermediate,
//                            ExpirationDate = DateTime.Now.AddHours(3),
//                            Assigner = new User
//                            {
//                                FirstName = "Joe",
//                                LastName = "Howard"
//                            }
//                        }
//                    });
//                });

//            _mockAssignTestRepository.Setup(x => x.GetUserAssignedTestByIdAsync(It.IsAny<int>()))
//                .Returns(async () =>
//                {
//                    return await Task.Factory.StartNew<IList<AssignTest>>(() => new List<AssignTest>()
//                    {
//                        new AssignTest
//                        {
//                            Id = 3,
//                            LevelType = LevelType.Beginner,
//                            ExpirationDate = DateTime.Now.AddHours(3),
//                            Assigner = new User
//                            {
//                                FirstName = "Tom",
//                                LastName = "Smith"
//                            }
//                        },
//                        new AssignTest
//                        {
//                            Id = 4,
//                            LevelType = LevelType.Intermediate,
//                            ExpirationDate = DateTime.Now.AddHours(3),
//                            Assigner = new User
//                            {
//                                FirstName = "Willy",
//                                LastName = "Harrington"
//                            }
//                        }
//                    });
//                });

//            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();

//            _userService = new UserService(_mockUserRepository.Object, _mockHistoryRepository.Object, _mockAssignTestRepository.Object, _mapper);
//        }

//        [Fact]
//        public async Task GetUserHistoryByIdAsync_HistoryModelIsValid_ResultWithValidMarkAndLevel()
//        {
//            // Arrange
//            var history = _mockUserRepository.Object.GetByIdAsync(1);

//            // Act
//            var result = await _userService.GetUserHistoryByIdAsync(history.Id);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal(50, result[0].Mark);
//            Assert.Equal(LevelType.Beginner, result[0].Level);
//            Assert.Equal(100, result[1].Mark);
//            Assert.Equal(LevelType.Elementary, result[1].Level);
//        }

//        [Fact]
//        public async Task GetHrUserHistoryByIdAsync_HrHistroryModelIsValid_ResultWithValidFullName()
//        {
//            // Arrange
//            var history = _mockUserRepository.Object.GetByIdAsync(1);

//            // Act
//            var result = await _userService.GetHrUserHistoryByIdAsync(history.Id);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal("Aaron Ramsdale", result[0].FullName);
//            Assert.Equal("Sam Johnstone", result[1].FullName);
//        }

//        [Fact]
//        public async Task GetUserAssignedTestByIdAsync_HrAssignTestModelIsValid_ResultWithCorrectData()
//        {
//            // Arrange
//            var test = _mockAssignTestRepository.Object.GetByIdAsync(1);

//            // Act
//            var result = await _userService.GetUserAssignedTestByIdAsync(test.Id);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal("Tom Smith", result[0].AssignedBy);
//            Assert.Equal(LevelType.Beginner, result[0].Level);
//            Assert.Equal("Willy Harrington", result[1].AssignedBy);
//            Assert.Equal(LevelType.Intermediate, result[1].Level);
//        }

//        [Fact]
//        public async Task GetHrAssignedTestByIdAsync_HrAssignTestModelIsValid_ResultWithCorrectData()
//        {
//            // Arrange
//            var test = _mockAssignTestRepository.Object.GetByIdAsync(1);

//            // Act
//            var result = await _userService.GetHrAssignedTestByIdAsync(test.Id);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal("Bob Holland", result[0].AssignedBy);
//            Assert.Equal(LevelType.Beginner, result[0].Level);
//            Assert.Equal("Joe Howard", result[1].AssignedBy);
//            Assert.Equal(LevelType.Intermediate, result[1].Level);
//        }
//    }
//}
