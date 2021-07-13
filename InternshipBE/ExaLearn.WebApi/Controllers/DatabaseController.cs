using ExaLearn.Dal;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/database")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly IGenericRepository<Question> _questionRepository;
        private readonly IGenericRepository<Answer> _answerRepository;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public DatabaseController(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager, IGenericRepository<Question> questionRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _questionRepository = questionRepository;
        }

        [HttpGet]
        public async Task Seed()
        {
            await DbInitializer.Seed(_userManager, _roleManager, _questionRepository, _answerRepository);
        }
    }
}

//{ StatusCode = 500, Message = Unable to resolve service for type 'ExaLearn.Dal.Interfaces.IGenericRepository`
//1[ExaLearn.Dal.Entities.Question]' while attempting to activate 'ExaLearn.WebApi.Controllers.DatabaseController'. }
