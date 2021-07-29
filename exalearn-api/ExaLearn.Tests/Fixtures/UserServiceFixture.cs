using ExaLearn.Dal.Entities;
using System.Threading.Tasks;

namespace ExaLearn.Tests.Fixtures
{
    public static class UserServiceFixture
    {
        public static async Task<User> GetIdAsync() => new User() { Email = "adminexa@mailnesia.com" };
    }
}
