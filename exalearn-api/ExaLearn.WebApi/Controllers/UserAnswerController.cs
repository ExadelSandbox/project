using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/userAnswers")]
    [ApiController]
    public class UserAnswerController : ControllerBase
    {

        private readonly IUserAnswerService _userAnswerService;

        public UserAnswerController(IUserAnswerService userAnswerService)
        {
            _userAnswerService = userAnswerService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(List<UserAnswerDTO> userAnswers)
        {
            return Ok(await _userAnswerService.CreateUserAnswersAsync(userAnswers));
        }
    }
}
