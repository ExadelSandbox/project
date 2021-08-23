using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface ITestService
    {
        Task<PassedTestForCheckDTO> GetUserTestByPassedTestIdAsync(int passedTestId, string checkerEmail);

        Task<AssessmentDTO> CreateAssesmentAsync(AssessmentDTO assessmentDTO);

        Task<IList<PassedTestDTO>> GetUnverifiedTestsForCoachAsync(string checkerEmail);
    }
}
