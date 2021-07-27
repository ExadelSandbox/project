using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Tests.Fixtures
{
    public static class UserServiceFixture
    {
        public static async Task<User> GetIdAsync() => new User() { Email = "adminexa@mailnesia.com" };
        public static async Task<IList<History>> GetUserHistoryIdAsync() => new List<History>() { 
            new History { Id = 1, UserId = 1, PassedTestId = 1 }, 
            new History { Id = 2, UserId = 1, PassedTestId = 1 } 
        };
    }
}
