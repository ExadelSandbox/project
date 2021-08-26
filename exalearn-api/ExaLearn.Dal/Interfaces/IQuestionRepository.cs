using ExaLearn.Dal.Entities;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        public Task<List<Question>> GetByExpressionAsync(Expression<Func<Question, bool>> expression, int take);

        public Task<List<Question>> GetByExpressionAsync(Expression<Func<Question, bool>> expression);

        public Task<List<Question>> GetGrammarQuestionsAsync(LevelType levelType);

        public Task<List<Question>> GetAuditionQuestionsAsync(LevelType levelType);

        public Task<List<Question>> GetTopicsAsync();

        public Task<Question> GetQuestionByIdAsync(int id);
    }
}
