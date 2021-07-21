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
        public async Task<IActionResult> GetAllQuestions()
        {
            return Ok(await _questionService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _questionService.GetByIdAsync(id));
        }

        [HttpGet("{level}/{type}")]
        public async Task<IActionResult> GetByLevelAndType(LevelType level, QuestionType type)
        {
            return Ok(await _questionService.GetByLevelAndTypeAsync(level, type));
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.CreateAsync(question));
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.UpdateAsync(question));
        }
    }
}
