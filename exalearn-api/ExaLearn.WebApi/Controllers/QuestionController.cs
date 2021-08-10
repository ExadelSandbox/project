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
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
       
        [HttpGet("generateTest/{levelType}")]
        public async Task<IActionResult> GenerateTest(LevelType levelType)
        {
            return Ok(await _questionService.GenerateTestAsync(levelType));
        }
        
        [HttpPost("createGrammar")]
        public async Task<IActionResult> CreateGrammar([FromBody] GrammarQuestionDTO question)
        {
            return Ok(await _questionService.CreateGrammarQuestionAsync(question));
        }

        [HttpPost("createAudition")]
        public async Task<IActionResult> CreateAudition([FromBody] AuditionQuestionDTO question)
        {
            return Ok(await _questionService.CreateAudioQuestionAsync(question));
        }

        [HttpPost("createTopic")]
        public async Task<IActionResult> CreateTopic([FromBody] TopicQuestionDTO question)
        {
            return Ok(await _questionService.CreateTopicQuestionAsync(question));
        }

        [HttpPost("createPassedTest")]
        public async Task<IActionResult> CreatePassedTest([FromBody] PassedTestDTO passedTest)
        {
            return Ok(await _questionService.CreatePassedTestAsync(passedTest));
        }
    }
}
