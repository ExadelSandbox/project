using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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

        [HttpGet("user")]
        public async Task<IActionResult> GetUserInfo()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            return Ok(await _userService.GetUserInfoByIdAsync(user.Id));
        }

        [HttpGet("{id}/myTestHistory")]
        public async Task<IActionResult> GetUserHistoryById(int id)
        {
            return Ok(await _userService.GetUserHistoryByIdAsync(id));
        }

        [HttpGet("{id}/myAssignedTests")]
        public async Task<IActionResult> GetUserAssignedTestById(int id)
        {
            return Ok(await _userService.GetUserAssignedTestByIdAsync(id));
        }

        #region ASSIGN TEST
        [HttpGet("getUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpPost("assignTests")]
        public async Task<IActionResult> CreateAssignedTest([FromBody] AssignedTestDTO assignedTestDTO)
        {
            return Ok(await _userService.CreateAssignedTestAsync(assignedTestDTO));
        }
        #endregion  

        [HttpGet("{id}/allAssignedTest")]
        public async Task<IActionResult> GetHrAssignedTestById(int id)
        {
            return Ok(await _userService.GetHrAssignedTestByIdAsync(id));
        }

        //[HttpGet("{id}/hrUserHistory")]
        //public async Task<IActionResult> GetHrUserHistoryById(int id)
        //{
        //    return Ok(await _userService.GetHrUserHistoryByIdAsync(id));
        //}
    }
}
