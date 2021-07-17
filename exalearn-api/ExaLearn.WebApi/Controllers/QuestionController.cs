using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/questions")]
    [ApiController]
    [Authorize]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuestionsAsync()
        {
            return Ok(await _questionService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await _questionService.GetAsync(id));
        }

        [HttpGet("{level}/{type}")]
        public async Task<IActionResult> GetByLevelAndTypeAsync(LevelType level, QuestionType type)
        {
            return Ok(await _questionService.GetByLevelAndTypeAsync(level, type));
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddAsync([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.AddAsync(question));
        }

        [HttpPost("save")]
        public async Task<IActionResult> SaveAsync([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.SaveAsync(question));
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateAsync([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.UpdateAsync(question));
        }
    }
}
