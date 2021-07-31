using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IUserAnswerService
    {
        Task<List<UserAnswerDTO>> AddUserAnswers(List<UserAnswerDTO> userAnswersDTO);
    }
}
