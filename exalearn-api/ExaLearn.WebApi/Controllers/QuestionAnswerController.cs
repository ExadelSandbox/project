using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/questionAnswer")]
    [ApiController]
    public class QuestionAnswerController : ControllerBase
    {
        private readonly IQuestionAnswerService _questionAnswerService;

        public QuestionAnswerController(IQuestionAnswerService questionAnswerService)
        {
            _questionAnswerService = questionAnswerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestionAsync(QuestionAnswerDTO questionAnswerDTO)
        {
            return Ok(await _questionAnswerService.AddAsync(questionAnswerDTO));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestionAsync(int id)
        {
            return Ok(await _questionAnswerService.GetAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuestionsAsync()
        {
            return Ok(await _questionAnswerService.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveQuestionAsync(QuestionAnswerDTO questionAnswerDTO)
        {
            return Ok(await _questionAnswerService.RemoveAsync(questionAnswerDTO));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuestionAsync(QuestionAnswerDTO questionAnswerDTO)
        {
            return Ok(await _questionAnswerService.UpdateAsync(questionAnswerDTO));
        }
    }
}
