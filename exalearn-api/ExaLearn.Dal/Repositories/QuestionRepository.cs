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
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {        
        public QuestionRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {            
        }

        public async Task<List<Question>> GetByLevelAndTypeAsync(LevelType level, QuestionType type)
        {
            return await _appDbContext.Questions.Where(x => x.EnglishLevel.Level == level && x.Type == type).ToListAsync();
        }

        public async Task<List<Question>> GetByLevelAsync(LevelType level)
        {
            return await _appDbContext.Questions.Where(x => x.EnglishLevel.Level == level).ToListAsync();
        }

        public async Task<List<Question>> GetByTypeAsync(QuestionType type)
        {
            return await _appDbContext.Questions.Where(x => x.Type == type).ToListAsync();
        }
    }
}
