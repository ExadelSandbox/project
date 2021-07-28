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

        public Task<List<Question>> GetGrammarQuestionAsync(LevelType levelType);

        public Task<List<Question>> GetAuditionQuestionAsync(LevelType levelType);

        public Task<List<Question>> GetTopicAsync(LevelType levelType);
    }
}
