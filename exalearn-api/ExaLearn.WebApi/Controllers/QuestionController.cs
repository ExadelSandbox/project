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
        public async Task<IActionResult> GenerateTestAsync(GenerateTestDTO generateTestDTO)
        {
            return Ok(await _questionService.GenerateTestAsync(generateTestDTO));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("createGrammar")]
        public async Task<IActionResult> CreateGrammarAsync([FromBody] GrammarQuestionDTO question)
        {
            return Ok(await _questionService.CreateGrammarQuestionAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("createAudition")]
        public async Task<IActionResult> CreateAuditionAsync([FromBody] AuditionQuestionDTO[] question)
        {
            return Ok(await _questionService.CreateAudioQuestionAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("createTopic")]
        public async Task<IActionResult> CreateTopicAsync([FromBody] TopicQuestionDTO[] question)
        {
            return Ok(await _questionService.CreateTopicQuestionAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpGet("get/{level}/{questionType}")]
        public async Task<IActionResult> GetByTypeAsync(LevelType? level, QuestionType questionType = QuestionType.Grammar)
        {
            return Ok(await _questionService.GetByTypeAsync(level, questionType));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _questionService.GetByIdAsync(id));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("save")]
        public async Task<IActionResult> SaveAsync([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.UpdateAsync(question));
        }

        [Authorize(Roles = RoleNames.Coach)]
        [HttpPost("delete")]
        public async Task<IActionResult> DeleteAsync([FromBody] QuestionDTO question)
        {
            return Ok(await _questionService.DeleteAsync(question));
        }
    }
}
