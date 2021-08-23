using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Core.Constants;
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

        [HttpPost("generateTest")]
        public async Task<IActionResult> GenerateTest(GenerateTestDTO generateTestDTO)
        {
            return Ok(await _questionService.GenerateTestAsync(generateTestDTO));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("createGrammar")]
        public async Task<IActionResult> CreateGrammar([FromBody] GrammarQuestionDTO question)
        {
            return Ok(await _questionService.CreateGrammarQuestionAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("createAudition")]
        public async Task<IActionResult> CreateAudition([FromBody] AuditionQuestionDTO[] question)
        {
            return Ok(await _questionService.CreateAudioQuestionAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("createTopic")]
        public async Task<IActionResult> CreateTopic([FromBody] TopicQuestionDTO[] question)
        {
            return Ok(await _questionService.CreateTopicQuestionAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpGet("getQuestions/{level}/{questionType}")]
        public async Task<IActionResult> GetQuestionsForChanging(LevelType? level, QuestionType questionType = QuestionType.Grammar)
        {
            return Ok(await _questionService.GetQuestionsAsync(level, questionType));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpGet("changeQuestion/{id}")]
        public async Task<IActionResult> ChangeQuestion(int id)
        {
            return Ok(await _questionService.GetQuestionByIdAsync(id));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("saveChangedQuestion")]
        public async Task<IActionResult> SaveChangedQuestion([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.UpdateQuestionAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("deleteQuestion")]
        public async Task<IActionResult> DeleteQuestion([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.DeleteQuestionAsync(question));
        }
    }
}
