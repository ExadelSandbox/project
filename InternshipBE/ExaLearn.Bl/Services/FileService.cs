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

namespace ExaLearn.Bl.Services
{
    public class FileService : IFileService
    {
        IGenericRepository<FileEntry> _filesRepository;
        IConfiguration _configuration; //it should be in startup.. but for now i do it like this
        public FileService(IGenericRepository<FileEntry> filesRepository, IConfiguration configuration)
        {
            _filesRepository = filesRepository;
            _configuration = configuration;
        }

        public async Task<FileEntry> AddAsync(IFormFile file)
        {
            var fileEntry = new FileEntry();

            if (file != null && file.Length >= 0) 
            {
                var fileType = Path.GetExtension(file.FileName);
                var isNessesaryFormat = AudioExtensions.AvalableAudutionExtensions.Any(e => e.Contains(fileType.ToLower()));

                if (isNessesaryFormat)
                {
                    var filePath = _configuration.GetConnectionString("HostingContext");

                    using (var stream = new FileStream(Path.Combine(filePath, Path.GetRandomFileName()), FileMode.Create)) //random filename or not?
                    {
                        await file.CopyToAsync(stream);
                    }
                    fileEntry.Name = file.FileName;
                    fileEntry.Url = filePath;
                }
            }

            return await _filesRepository.AddAsync(fileEntry);
        }


        public async Task<FileEntry> GetAsync(FileEntry fileEntry)
        {
            return await _filesRepository.GetAsync(fileEntry);
        }
        public async Task<List<FileEntry>> GetFilesAsync()
        {
            return await _filesRepository.GetAllAsync();
        }
    }
}
