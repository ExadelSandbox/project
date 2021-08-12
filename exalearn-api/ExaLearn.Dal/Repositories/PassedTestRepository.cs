using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class PassedTestRepository : GenericRepository<PassedTest>, IPassedTestRepository
    {
        public PassedTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<PassedTest> GetUserTestByPassedTestIdAsync(int passedTestId)
        {
            var test = await _appDbContext.PassedTests
                .Where(x => x.Id == passedTestId)
                .Include(x => x.UserTest)
                .Include(x => x.UserAnswers)
                .FirstOrDefaultAsync();
            return test;
        }
    }
}
