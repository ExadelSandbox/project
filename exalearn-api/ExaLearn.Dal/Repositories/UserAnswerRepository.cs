using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class UserAnswerRepository : GenericRepository<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<UserAnswer>> CreateUserAnswersAsync(List<UserAnswer> userAnswers)
        {
            await _appDbContext.AddRangeAsync(userAnswers);
            await _appDbContext.SaveChangesAsync();
            return userAnswers;
        }

        public async Task<List<UserAnswer>> GetUserAnswersByPassedTestId(int passedTestId)
        {
            List<UserAnswer> checkUserAnswers = await _appDbContext.UserAnswers.Where(x =>
            x.PassedTestId == passedTestId &&
            x.Question.QuestionType == QuestionType.Topic)
                .ToListAsync();
            return checkUserAnswers;
        }
    }
}
