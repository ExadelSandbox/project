using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        IFileRepository filesRepository;
        IWebHostEnvironment appEnvironment;

        public FilesController(IWebHostEnvironment appEnvironment, IFileRepository filesRepository)
        {
            this.appEnvironment = appEnvironment;
            this.filesRepository = filesRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(IFormFile file)
        {
            try
            {
                /*
                 do not forget to clarify the point regarding the naming of files!
                 we can generate:

                 1.random filenames
                 2.say that such a file exists
                 3.rewrite if names match

                */

                string fileType = Path.GetExtension(file.FileName);

                if (fileType.ToLower() == ".mp3" || fileType.ToLower() == ".wma")
                {
                    string filePath = "/Files/Audio/" + file.FileName; //absolute path to audiofile

                    if (file != null && file.Length >= 0)
                    {
                        using (var stream = new FileStream(appEnvironment.WebRootPath + filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        FileDetail fileDetails = new FileDetail()
                        {
                            Name = file.FileName,
                            Formats = 0,
                            Url = filePath
                        };

                        await filesRepository.Add(fileDetails);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                return Ok();
            }
            catch (IOException)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FileDetail>> Get(int id)
        {
            return await filesRepository.GetFileById(id);
        }

        [HttpGet]
        public async Task<List<FileDetail>> Get()
        {
            return await filesRepository.GetAllFiles();
        }
    }
}
