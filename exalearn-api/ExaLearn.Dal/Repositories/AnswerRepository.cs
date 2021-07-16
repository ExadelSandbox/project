using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>, IAnswerRepository
    {
        protected new ExaLearnDbContext _appDbContext;
        public AnswerRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Answer>> GetByQuestionId(int id)
        {
            return await _appDbContext.Answers.Where(x => x.QuestionId == id).ToListAsync();
        }
    }
}
