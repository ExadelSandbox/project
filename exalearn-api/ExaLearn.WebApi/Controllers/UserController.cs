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
        private readonly UserManager<User> _userManager;

        public UserController(IUserService userService, UserManager<User> userManager)
        {
            _userService = userService;
            _userManager = userManager;
        }

        [HttpGet("api/user")]
        public async Task<IActionResult> GetUserInfo()
        {
            return Ok(await _userService.GetUserInfo(await _userManager.FindByNameAsynch(User.Identity.Name)));
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
    }
}
