using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.Core.Constants;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/files")]
    [ApiController]
    [Authorize(Roles = RoleNames.Coach)]
    public class FileController : ControllerBase
    {
        private readonly IAudioFileService _fileService;

        public FileController(IAudioFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFile(AudioFileDTO audioFileDTO)
        {
            return Ok(await _fileService.CreateAsync(audioFileDTO));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFile(int id)
        {
            return Ok(await _fileService.GetByIdAsync(id));
        }
    }
}
