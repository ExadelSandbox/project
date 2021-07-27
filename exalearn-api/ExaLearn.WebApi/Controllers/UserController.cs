using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userService.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpGet("{id}/userHistory")]
        public async Task<IActionResult> GetUserHistoryById(int id)
        {
            return Ok(await _userService.GetUserHistoryByIdAsync(id));
        }

        [HttpGet("{id}/hrUserHistory")]
        public async Task<IActionResult> GetHrUserHistoryById(int id)
        {
            return Ok(await _userService.GetHrUserHistoryByIdAsync(id));
        }

        [HttpGet("{id}/UserAssignedTest")]
        public async Task<IActionResult> GetUserAssignedTestById(int id)
        {
            return Ok(await _userService.GetUserAssignedTestByIdAsync(id));
        }
    }
}
