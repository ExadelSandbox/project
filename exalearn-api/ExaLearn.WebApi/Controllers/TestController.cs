using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Core.Constants;
using System.Threading.Tasks;


namespace ExaLearn.WebApi.Controllers
{
    [Route("api/tests")]
    [ApiController]
    [Authorize(Roles = RoleNames.Coach)]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("getTestForCoachCheck/{passedTestId}")]
        public async Task<IActionResult> GetTestForCheck(int passedTestId)
        {
            var userName = User.Identity.Name;
            return Ok(await _testService.GetUserTestByPassedTestIdAsync(passedTestId, userName));
        }

        [HttpPost("testAssessment")]
        public async Task<IActionResult> TestAssessment(AssessmentDTO assessmentDTO)
        {
            return Ok(await _testService.CreateAssesmentAsync(assessmentDTO));
        }

        [HttpGet("getUnverifiedTests")]
        public async Task<IActionResult> GetUnverifiedTests()
        {
            var userName = User.Identity.Name;
            return Ok(await _testService.GetUnverifiedTestsAsync(userName));
        }
    }
}
