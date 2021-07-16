using ExaLearn.Dal.Entities;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        public Task<List<Question>> GetByLevelAndTypeAsync(LevelType level, QuestionType type);
        public Task<List<Question>> GetByTypeAsync(QuestionType type);
        public Task<List<Question>> GetByLevelAsync(LevelType level);
    }
}
