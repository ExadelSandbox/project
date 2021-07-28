using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.WebApi.Controllers;
using Moq;
using System.Threading.Tasks;
using Xunit;
using System;
using Shared.Enums;

namespace ExaLearn.Tests.Controllers
{
    public class UserControllerTests
    {
        private readonly Mock<IUserService> _mockUserService;

        public UserControllerTests()
        {
            _mockUserService = new Mock<IUserService>();
        }

        [Fact]
        public async Task GetHrAssignedTestByIdAsync_OkResult_NotNull()
        {
            //Arrange
            HrAssignedTestDTO[] assignedTests = new HrAssignedTestDTO[]
            {
                new HrAssignedTestDTO
                {
                    Id = 1,
                    AssignedBy = "hrexa@mailnesia.com",
                    ExpireDate = DateTime.Now.AddHours(3),
                    Level = LevelType.Beginner,
                    Passed = false
                },

                new HrAssignedTestDTO
                {
                    Id = 2,
                    AssignedBy = "hrexa@mailnesia.com",
                    ExpireDate = DateTime.Now.AddHours(3),
                    Level = LevelType.Beginner,
                    Passed = false
                },

                new HrAssignedTestDTO
                {
                    Id = 3,
                    AssignedBy = "hrexa@mailnesia.com",
                    ExpireDate = DateTime.Now.AddHours(3),
                    Level = LevelType.Beginner,
                    Passed = false
                }
            };

            _mockUserService.Setup(p => p.GetHrAssignedTestByIdAsync(1))
                .ReturnsAsync(assignedTests);

            var _controller = new UserController(_mockUserService.Object);

            // Act
            dynamic result = await _controller.GetHrAssignedTestById(1);
            var list = await _mockUserService.Object.GetHrAssignedTestByIdAsync(1);

            // Assert
            Assert.NotEmpty(list);
            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
        }
    }
}
