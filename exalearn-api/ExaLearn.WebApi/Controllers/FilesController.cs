﻿using ExaLearn.Bl.Interfaces;
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
    public class FilesController : ControllerBase
    {
        private readonly IAudioFileService _fileService;

        public FilesController(IAudioFileService fileService)
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
