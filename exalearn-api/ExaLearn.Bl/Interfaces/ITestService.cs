using ExaLearn.Bl.DTO;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface ITestService
    {
        Task<PassedTestDTO> GetUserTestByPassedTestIdAsync(int passedTestId, string checker);
    }
}
