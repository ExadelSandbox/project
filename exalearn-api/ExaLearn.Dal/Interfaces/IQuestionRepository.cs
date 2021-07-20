using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        public Task<List<Question>> GetByExpressionAsync(Expression<Func<Question, bool>> expression);        
    }
}
