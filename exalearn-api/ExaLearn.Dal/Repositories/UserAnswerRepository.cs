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

        public async Task<List<Answer>> GetCorrectQuestionsAnswers(int passedTestId)
        {
            var correctAnswers = _appDbContext.PassedTests
                .Where(x => x.Id == passedTestId)
                .Include(x => x.UserTest)
                .ThenInclude(x => x.Questions)
                .ThenInclude(x => x.Answers)
                .SelectMany(x => x.UserTest.Questions
                .Where(q => q.QuestionType == QuestionType.Grammar || q.QuestionType == QuestionType.Audition))
                .Select(x => x.Answers.Where(y => y.IsCorrect).SingleOrDefault());

            return await correctAnswers.ToListAsync();
        }
    }
}
