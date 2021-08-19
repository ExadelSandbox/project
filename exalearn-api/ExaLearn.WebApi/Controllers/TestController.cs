﻿using ExaLearn.Bl.DTO;
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

        [Authorize(Roles = "Coach")]
        [HttpGet("getTestForCoachCheck/{passedTestId}")]
        public async Task<IActionResult> GetTestForCoachCheck(int passedTestId)
        {
            var checkerEmail = User.Identity.Name;
            return Ok(await _testService.GetUserTestByPassedTestIdAsync(passedTestId, checkerEmail));
        }

        [Authorize(Roles = "Coach")]
        [HttpPost("testAssessment")]
        public async Task<IActionResult> TestAssessment(AssessmentDTO assessmentDTO)
        {
            return Ok(await _testService.CreateAssesmentAsync(assessmentDTO));
        }

        [Authorize(Roles = "Coach")]
        [HttpGet("getUnverifiedTests")]
        public async Task<IActionResult> GetUnverifiedTests()
        {
            return Ok(await _testService.GetUnverifiedTestsForCoachAsync());
        }
    }
}
