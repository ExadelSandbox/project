using ExaLearn.Dal.Entities;
using System.Threading.Tasks;

namespace ExaLearn.Tests.Fixture
{
    public static class AuthenticateControllerrFixture
    {
        public static async Task<User> GetUserNameAsync() => new User() { UserName = "adminexa@mailnesia.com" };

        public static async Task<bool> IsCorrectPasswordAsync() => true;

        public static string GetJWTSecret() => "StrONGKAutHENTICATIONKEy";

        public static string GetJWTValidIssuer() => "http://localhost:59921";

        public static string GetJWTValidAudience() => "http://localhost:4200";
    }
}
