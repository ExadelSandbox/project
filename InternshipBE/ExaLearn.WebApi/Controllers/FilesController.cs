using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/files")]
    [ApiController]
    [Authorize]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFileAsync(IFormFile file)
        {
            return Ok(await _fileService.AddAsync(file));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFileAsync(int id)
        {
            return Ok(await _fileService.GetAsync(id));
        }
    }
}
