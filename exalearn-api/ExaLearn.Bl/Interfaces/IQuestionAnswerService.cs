using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionAnswerService
    {
        public Task<UserAnswerDTO> AddAsync(UserAnswerDTO questionAnswerDTO);

        public Task<UserAnswerDTO> GetByIdAsync(int id);

        public Task<List<UserAnswerDTO>> GetAllAsync();

        public Task<UserAnswerDTO> RemoveAsync(UserAnswerDTO questionAnswerDTO);

        public Task<UserAnswerDTO> UpdateAsync(UserAnswerDTO questionAnswerDTO);
    }
}
