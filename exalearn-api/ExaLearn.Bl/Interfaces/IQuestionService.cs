using ExaLearn.Bl.DTO;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionService
    {
        public Task<QuestionDTO> CreateAsync(QuestionDTO question);

        public Task<List<QuestionDTO>> GetAllAsync();

        public Task<QuestionDTO> GetByIdAsync(int id);

        public Task<List<QuestionDTO>> GetByLevelAsync(LevelType level);

        public Task<List<QuestionDTO>> GetByTypeAsync(QuestionType type);

        public Task<List<QuestionDTO>> GetByLevelAndTypeAsync(LevelType level, QuestionType type);

        public Task<QuestionDTO> UpdateAsync(QuestionDTO question);
    }
}
