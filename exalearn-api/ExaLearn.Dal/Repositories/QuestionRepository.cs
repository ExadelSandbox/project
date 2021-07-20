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

        public async Task<List<Question>> GetByExpressionAsync(Expression<Func<Question, bool>> expression)
        {
            return await _appDbContext.Questions.Where(expression).ToListAsync();
        }
    }
}