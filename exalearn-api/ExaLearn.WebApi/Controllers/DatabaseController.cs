using ExaLearn.Dal;
using ExaLearn.Dal.Database;
using ExaLearn.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/database")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public DatabaseController(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager, ExaLearnDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            dbContext.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task Seed()
        {
            await DbInitializer.Seed(_userManager, _roleManager);
        }
    }
}
