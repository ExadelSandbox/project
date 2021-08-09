using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/userAnswers")]
    [ApiController]
    [Authorize]
    public class UserAnswerController : ControllerBase
    {

        private readonly IUserAnswerService _userAnswerService;

        public UserAnswerController(IUserAnswerService userAnswerService)
        {
            _userAnswerService = userAnswerService;
        }

        [HttpPost("create")]
        public IActionResult Create(List<UserAnswerDTO> userAnswers)
        {
            return Ok(_userAnswerService.CreateUserAnswersAsync(userAnswers));
        }

        [HttpGet("check/{passedTestId}")]
        public IActionResult Check(int passedTestId)
        {
            return Ok(_userAnswerService.CheckUserAnswersAsync(passedTestId, User.Identity.Name.ToString()));
        }
    }
}
