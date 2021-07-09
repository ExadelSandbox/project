using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
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
        public async Task<IActionResult> Get(FileEntry fileEntry)
        {
            return Ok(await _fileService.GetAsync(fileEntry));
        }
    }
}
