using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/userAnswer")]
    [ApiController]
    public class UserAnswerController : ControllerBase
    {

        private readonly IUserAnswerService _userAnswerService;

        public UserAnswerController(IUserAnswerService userAnswerService)
        {
            _userAnswerService = userAnswerService;
        }

        [HttpPost("add")]
        public IActionResult Add(List<UserAnswerDTO> userAnswers)
        {
            return Ok(_userAnswerService.AddUserAnswers(userAnswers));
        }
    }
}
