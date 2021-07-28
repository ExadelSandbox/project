using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.WebApi.Controllers;
using Moq;
using Shared.Enums;
using System;
using System.Threading.Tasks;
using Xunit;

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
        public async Task GetUserAssignedTestByIdAsync_OkResult_NotNull_NotEmpty()
        {
            //Arrange
            UserAssignedTestDTO[] userAssignedTests = new UserAssignedTestDTO[]
            {
                new UserAssignedTestDTO
                {
                    Id = 1,
                    AssignedBy = "hrexa@mailnesia.com",
                    ExpireDate = DateTime.Now.AddHours(3),
                    Level = LevelType.Beginner
                },

                new UserAssignedTestDTO
                {
                    Id = 2,
                    AssignedBy = "hrexa@mailnesia.com",
                    ExpireDate = DateTime.Now.AddHours(3),
                    Level = LevelType.Beginner
                },

                new UserAssignedTestDTO
                {
                    Id = 3,
                    AssignedBy = "hrexa@mailnesia.com",
                    ExpireDate = DateTime.Now.AddHours(3),
                    Level = LevelType.Beginner
                },
            };

            _mockUserService.Setup(p => p.GetUserAssignedTestByIdAsync(1)).ReturnsAsync(userAssignedTests);

            var _controller = new UserController(_mockUserService.Object);

            //Act
            dynamic result = await _controller.GetUserAssignedTestById(1);
            var list = await _mockUserService.Object.GetUserAssignedTestByIdAsync(1);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotEmpty(list);
        }
    }
}
