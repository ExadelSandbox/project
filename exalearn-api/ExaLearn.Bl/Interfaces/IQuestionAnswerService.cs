using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionAnswerService
    {
        public Task<QuestionAnswerDTO> AddAsync(QuestionAnswerDTO questionAnswerDTO);

        public Task<QuestionAnswerDTO> GetByIdAsync(int id);

        public Task<List<QuestionAnswerDTO>> GetAllAsync();

        public Task<QuestionAnswerDTO> RemoveAsync(QuestionAnswerDTO questionAnswerDTO);

        public Task<QuestionAnswerDTO> UpdateAsync(QuestionAnswerDTO questionAnswerDTO);
    }
}
