using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Tests.Fixtures
{
    public static class UserServiceFixture
    {
        public static async Task<User> GetIdAsync() => new User() { Email = "adminexa@mailnesia.com" };
        public static async Task<IList<History>> GetListHistoryAsync() => new List<History>() {
            new History {
                Id = 1,
                PassedTest = new PassedTest() {
                    Assessment = 50 }
            },
        };

        public static async Task<IList<PassedTest>> GetHrHistoryAsync() => new List<PassedTest>() {
            new PassedTest {
                Id = 1,
                User =  new  User() {
                    FirstName = "firstName",
                    LastName = "lastName",
                }
            }
        };
    }
}
