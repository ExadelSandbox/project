using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class UserAnswerRepository : GenericRepository<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<Answer>> GetByExpressionAsync(Func<Question, bool> expression, int passedTestId)
        {
            return await _appDbContext.PassedTests
                .Where(x => x.Id == passedTestId)
                .Include(x => x.UserTest)
                .ThenInclude(x => x.Questions)
                .ThenInclude(x => x.Answers)
                .SelectMany(x => x.UserTest.Questions
                .Where(expression))
                .Select(x => x.Answers.Where(y => y.IsCorrect).SingleOrDefault())
                .ToListAsync();
        }
        public async Task<List<Answer>> GetGrammarQuestionAnswers(int passedTestId)
        {
            Func<Question, bool> takeGrammerQuestions = q => q.QuestionType == QuestionType.Grammar;
            return await GetByExpressionAsync(takeGrammerQuestions, passedTestId);
        }

        public async Task<List<Answer>> GetAuditionQuestionAnswers(int passedTestId)
        {
            Func<Question, bool> takeGrammerQuestions = q => q.QuestionType == QuestionType.Audition;
            return await GetByExpressionAsync(takeGrammerQuestions, passedTestId);
        }
    }
}
