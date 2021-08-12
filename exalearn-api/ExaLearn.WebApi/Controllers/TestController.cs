using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace ExaLearn.WebApi.Controllers
{
    [Route("api/tests")]
    [ApiController]
    [Authorize]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("getTestForCoachCheck/{passedTestId}")]
        public async Task<IActionResult> GetTestForCoachCheck(int passedTestId)
        {
            var checker = User.Identity.Name;
            return Ok(await _testService.GetUserTestByPassedTestIdAsync(passedTestId, checker));
        }
    }
}
