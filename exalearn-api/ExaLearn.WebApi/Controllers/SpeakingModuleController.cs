using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/speaking")]
    [ApiController]
    [Authorize]
    public class SpeakingModuleController : ControllerBase
    {
        private readonly IAudioFileService _audioFileService;

        public SpeakingModuleController(IAudioFileService audioFileService)
        {
            _audioFileService = audioFileService;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitSpeaking(IFormFile file) //speaker's audio file
        {
            var audioAnswer = await _audioFileService.CreateAsync(file);
            //send file url to the coach controller

            return Ok();
        }
        
    }
}
