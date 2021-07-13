using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
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

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(User user)
        {
            return Ok(await _userService.AddAsync(user));
        }

        [HttpGet]
        public async Task<IActionResult> GetUserAsync(int id)
        {
            return Ok(await _userService.GetAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveUserAsync(User user)
        {
            return Ok(await _userService.Remove(user));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(User user)
        {
            return Ok(await _userService.Update(user));
        }

    }
}
