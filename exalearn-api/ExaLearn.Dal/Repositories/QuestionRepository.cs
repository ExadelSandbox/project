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
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<Question>> GetByExpressionAsync(Expression<Func<Question, bool>> expression, int take)
        {
            var questions = _appDbContext.Questions
                .Where(expression)
                .Include(x => x.Answers)
                .OrderBy(g => Guid.NewGuid())
                .Take(take);

            return await questions.ToListAsync();
        }

        public async Task<List<Question>> GetGrammarQuestionsAsync(LevelType levelType)
        {
            Expression<Func<Question, bool>> takeGrammerQuestions = q => q.QuestionType == QuestionType.Grammar && q.LevelType == levelType;
            return await GetByExpressionAsync(takeGrammerQuestions, 10);
        }

        public async Task<List<Question>> GetAuditionQuestionsAsync(LevelType levelType)
        {
            var url = _appDbContext.Questions
                .Where(q => q.QuestionType == QuestionType.Audition && q.LevelType == levelType)
                .Select(x => x.FileUrl)
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefault();

            Expression<Func<Question, bool>> takeAuditionQuestions = q => q.QuestionType == QuestionType.Audition && q.LevelType == levelType && q.FileUrl == url;
            return await GetByExpressionAsync(takeAuditionQuestions, 10);
        }

        public async Task<List<Question>> GetTopicsAsync()
        {
            Expression<Func<Question, bool>> takeEssayTopic = q => q.QuestionType == QuestionType.Topic;
            return await GetByExpressionAsync(takeEssayTopic, 2);
        }

        public async Task<List<Question>> GetByExpressionAsync(Expression<Func<Question, bool>> expression)
        {
            var questions = _appDbContext.Questions
                .Where(expression)
                .Include(x => x.Answers)
                .OrderBy(g => g.Id);

            return await questions.ToListAsync();
        }

        public async Task<Question> GetQuestionByIdAsync(int id)
        {
            var question = _appDbContext.Questions
                .Where(x => x.Id == id)
                .Include(x => x.Answers)
                .FirstAsync();

            return await question;
        }
    }
}