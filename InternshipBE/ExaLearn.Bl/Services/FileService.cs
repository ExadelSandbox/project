using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Model;
using ExaLearn.Dal.Repositories;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ExaLearn.Bl.FileFormats;
using Microsoft.Extensions.Configuration;
using System.Linq;
using ExaLearn.Dal.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ExaLearn.Bl.Services
{
    public class FileService : IFileService
    {
        private readonly IGenericRepository<AudioFile> _filesRepository;
        private readonly IConfiguration _configuration; //it should be in startup.. but for now i do it like this

        public FileService(IGenericRepository<AudioFile> filesRepository, IConfiguration configuration)
        {
            _filesRepository = filesRepository;
            _configuration = configuration;
        }

        public async Task<AudioFile> AddAsync(IFormFile file)
        {
            if (file == null && file.Length <= 0)
                throw new ValidationException("File not found!");

            var fileType = Path.GetExtension(file.FileName);
            var isNessesaryFormat = AudioExtensions.AvailableAudutionExtensions.Contains(fileType.ToLower());

            if (!isNessesaryFormat)
                throw new ValidationException("File format does not meet the requirements!");

            var filePath = _configuration.GetConnectionString("HostingContext");

            using (var stream = new FileStream(Path.Combine(filePath, Path.GetRandomFileName()), FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var fileEntry = new AudioFile()
            {
                Name = file.Name,
                Url = filePath
            };

            return await _filesRepository.AddAsync(fileEntry);
        }

        public async Task<AudioFile> GetAsync(int id)
        {
            return await _filesRepository.GetAsync(id);
        }

        public async Task<List<AudioFile>> GetFilesAsync()
        {
            return await _filesRepository.GetAllAsync();
        }
    }
}
