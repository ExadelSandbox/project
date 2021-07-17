using ExaLearn.Dal.Entities;
using System.Threading.Tasks;

namespace ExaLearn.Tests.Fixture
{
    public static class AuthenticateControllerrFixture
    {
        public static async Task<User> GetUserNameAsync() => new User() { UserName = "userexa@mailnesia.com" };

        public static async Task<bool> IsCorrectPasswordAsync(bool isCorrect) => isCorrect;

        public static string GetJWTSecret() => "StrONGKAutHENTICATIONKEy";

        public static string GetJWTValidIssuer() => "http://localhost:59921";

        public static string GetJWTValidAudience() => "http://localhost:4200";
    }
}