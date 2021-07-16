using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/questionAnswer")]
    [ApiController]
    [Authorize]
    public class QuestionAnswerController : ControllerBase
    {
        private readonly IQuestionAnswerService _questionAnswerService;

        public QuestionAnswerController(IQuestionAnswerService questionAnswerService)
        {
            _questionAnswerService = questionAnswerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestion(QuestionAnswerDTO questionAnswerDTO)
        {
            return Ok(await _questionAnswerService.AddAsync(questionAnswerDTO));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestion(int id)
        {
            return Ok(await _questionAnswerService.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuestions()
        {
            return Ok(await _questionAnswerService.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveQuestion(QuestionAnswerDTO questionAnswerDTO)
        {
            return Ok(await _questionAnswerService.RemoveAsync(questionAnswerDTO));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuestion(QuestionAnswerDTO questionAnswerDTO)
        {
            return Ok(await _questionAnswerService.UpdateAsync(questionAnswerDTO));
        }
    }
}
