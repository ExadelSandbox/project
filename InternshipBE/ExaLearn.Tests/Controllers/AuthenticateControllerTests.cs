using ExaLearn.Dal.Entities;
using ExaLearn.Tests.Fixture;
using ExaLearn.WebApi.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ExaLearn.Tests
{
    public class AuthorizationControllerTests
    {
        private readonly Mock<UserManager<User>> _mockUserManager;
        private readonly Mock<IConfiguration> _mockConfiguration;

        public AuthorizationControllerTests()
        {
            var store = new Mock<IUserStore<User>>();

            _mockUserManager = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);
            _mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(AuthenticateControllerrFixture.TestFindByNameAsync());
            _mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(AuthenticateControllerrFixture.TestCheckPasswordAsyncTrue());

            _mockConfiguration = new Mock<IConfiguration>();
            _mockConfiguration.Setup(u => u["JWT:Secret"]).Returns(AuthenticateControllerrFixture.GetJWTSecret());
            _mockConfiguration.Setup(u => u["JWT:ValidIssuer"]).Returns(AuthenticateControllerrFixture.GetJWTValidIssuer());
            _mockConfiguration.Setup(u => u["JWT:ValidAudience"]).Returns(AuthenticateControllerrFixture.GetJWTValidAudience());
        }

        [Fact]
        public async Task FindByNameAsync_LoginModelIsEmpty_AllFieldsAreCorrect()
        {
            // Arrange
            var _controller = new AuthenticateController(_mockUserManager.Object, _mockConfiguration.Object);
            var loginModel = new LoginModel();

            // Act
            dynamic result = await _controller.Login(loginModel);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Value);
        }
    }
}
