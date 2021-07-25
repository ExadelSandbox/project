using ExaLearn.Bl.DTO;
using Shared.Enums;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IQuestionService
    {
        Task<TestDTO> GenerateTestAsync(LevelType level);
    }
}
