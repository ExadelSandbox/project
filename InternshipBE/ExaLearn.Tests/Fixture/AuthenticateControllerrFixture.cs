using ExaLearn.Dal.Entities;
using System.Threading.Tasks;

namespace ExaLearn.Tests.Fixture
{
    public static class AuthenticateControllerrFixture
    {
        public static async Task<User> TestFindByNameAsync()
        {
            return new User() { UserName = "adminexa@mailnesia.com" };
        }

        public static async Task<bool> TestCheckPasswordAsyncTrue()
        {
            return true;
        }

        public static async Task<bool> TestCheckPasswordAsyncFalse()
        {
            return false;
        }

        public static string GetJWTSecret() => "StrONGKAutHENTICATIONKEy";

        public static string GetJWTValidIssuer() => "http://localhost:59921";

        public static string GetJWTValidAudience() => "http://localhost:4200";
    }
}
