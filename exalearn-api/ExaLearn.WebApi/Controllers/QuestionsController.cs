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
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuestionsAsync()
        {
            return Ok(await _questionService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestionAsync(int id)
        {
            return Ok(await _questionService.GetAsync(id));
        }

        [HttpGet("{level}/{type}")]
        public async Task<IActionResult> GetQuestionsByLevelAndTypeAsync(LevelType level, QuestionType type)
        {
            return Ok(await _questionService.GetByLevelAndTypeAsync(level, type));
        }

        [HttpGet("{level}")]
        public async Task<IActionResult> GetQuestionsByLevelAsync(LevelType level)
        {
            return Ok(await _questionService.GetByLevelAsync(level));
        }

        [HttpGet("{type}")]
        public async Task<IActionResult> GetQuestionsByTypeAsync(QuestionType type)
        {
            return Ok(await _questionService.GetByTypeAsync(type));
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestionAsync([FromBody] QuestionDTO questionDTO)
        {
            return Ok(await _questionService.AddAsync(questionDTO));
        }

        //[HttpPost]
        //public async Task<IActionResult> SaveQuestionAsync([FromBody] QuestionDTO questionDTO)
        //{
        //    return Ok(await _questionService.SaveAsync(questionDTO));
        //}

        //[HttpPost]
        //public async Task<IActionResult> UpdateQuestionAsync([FromBody] QuestionDTO questionDTO)
        //{
        //    return Ok(await _questionService.UpdateAsync(questionDTO));
        //}
    }
}
