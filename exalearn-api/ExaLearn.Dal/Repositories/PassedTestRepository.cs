using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class PassedTestRepository : GenericRepository<PassedTest>, IPassedTestRepository
    {
        public PassedTestRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IList<PassedTest>> AllTestHistoryAsync()
        {
            return await _appDbContext.PassedTests
                .Include(x => x.User)
                .Include(x => x.Assessment)
                .Where(x => x.Status == StatusType.Checked)
                .ToListAsync();
        }

        public async Task<IList<PassedTest>> MyTestHistoryAsync(int userId)
        {
            return await _appDbContext.PassedTests
                .Include(x => x.User)
                .Include(x => x.Assessment)
                .Where(x => x.UserId == userId)
                .ToListAsync();
        }

        public async Task<PassedTest> GetUserTestByPassedTestIdAsync(int passedTestId)
        {
            var test = await _appDbContext.PassedTests
                .Where(x => x.Id == passedTestId)
                .Include(x => x.UserAnswers.OrderBy(x => x.Question.QuestionType))
                .ThenInclude(u => u.Question)
                .ThenInclude(y => y.Answers)
                .Include(x => x.Assessment)
                .FirstOrDefaultAsync();
            return test;
        }

        public async Task<IList<PassedTest>> GetUnverifiedTestsAsync(int userId)
        {
            return await _appDbContext.PassedTests
                .Where(x => (x.Status == StatusType.InCoachProgress && x.CheckerId == userId) || (x.Status == StatusType.Completed))
                .Include(x => x.User)
                .Include(x => x.Assessment)
                .ToListAsync();
        }

        public async Task CloseTestAsync(int id)
        {
            var test = await _appDbContext.PassedTests
                .Where(x => x.Id == id && x.Status == StatusType.Active)
                .FirstOrDefaultAsync();

            if (test != null)
            {
                test.Status = StatusType.Completed;
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}