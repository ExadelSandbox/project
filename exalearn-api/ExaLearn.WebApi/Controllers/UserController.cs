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

        [HttpGet("getUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpGet("myAssignedTests/{id}")]    // id must be at the end example: getUser{id}
        public async Task<IActionResult> GetUserAssignedTestById(int id)
        {
            return Ok(await _userService.GetUserAssignedTestByIdAsync(id)); 
        }

        #region ASSIGN TEST
        [HttpPost("assignTests")]
        public async Task<IActionResult> CreateAssignedTest([FromBody] AssignedTestDTO assignedTestDTO)
        {
            return Ok(await _userService.CreateAssignedTestAsync(assignedTestDTO));
        }
        

        [HttpGet("allAssignedTest/{id}")] // id must be at the end example: getUser{id}
        public async Task<IActionResult> GetHrAssignedTestById(int id)
        {
            return Ok(await _userService.GetHrAssignedTestByIdAsync(id)); //remove this method. what is this method for? how does it take all tests if it takes tests by id?
        }

        [HttpGet("allExpiredAssignedTest/{id}")] // id must be at the end example: getUser{id}
        public async Task<IActionResult> GetHrExpiredAssignedTestById(int id)
        {
            return Ok(await _userService.GetHrExpiredAssignedTestByIdAsync(id));
        }

        [HttpGet("allAssignedTests")]
        public async Task<IActionResult> AllAssignedAsync()
        {
            return Ok(await _userService.GetAllAssignedTests());
        }

        #endregion

        [HttpGet("allTestHistory")]
        public async Task<IActionResult> AllTestHistory()
        {
            return Ok(await _userService.AllTestHistoryAsync());
        }

        [HttpGet("{id}/myTestHistory")] // id must be at the end example: getUser{id}
        public async Task<IActionResult> MyTestHistoryAsync(int id)
        {
            return Ok(await _userService.MyTestHistoryAsync(id));
        }
    }
}
