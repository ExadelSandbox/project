using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionAnswerService
    {
        Task<UserAnswerDTO> CreateAsync(UserAnswerDTO questionAnswerDTO);

        Task<UserAnswerDTO> GetByIdAsync(int id);

        Task<List<UserAnswerDTO>> GetAllAsync();

        Task<UserAnswerDTO> DeleteAsync(UserAnswerDTO questionAnswerDTO);

        Task<UserAnswerDTO> UpdateAsync(UserAnswerDTO questionAnswerDTO);
    }
}
