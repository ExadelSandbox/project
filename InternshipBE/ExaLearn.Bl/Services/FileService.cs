using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Model;
using ExaLearn.Dal.Repositories;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ExaLearn.Bl.FileFormats;

namespace ExaLearn.Bl.Services
{
    public class FileService : IFileService
    {
        IFileRepository _filesRepository;

        public FileService(IFileRepository filesRepository)
        {
            _filesRepository = filesRepository;
        }

        public async Task<FileEntry> AddAsync(IFormFile file)
        {
            /*
             do not forget to clarify the point regarding the naming of files!
             we can generate:

             1.random filenames
             2.say that such a file exists
             3.rewrite if names match

            */

            var fileType = Path.GetExtension(file.FileName);

            var fileEntry = new FileEntry();

            foreach (var format in AudioExtensions.Extensions)
            {
                if (fileType.ToLower() == format) // realize this in enum
                {
                    var filePath = "/Files/Audio/" + file.FileName; //absolute path to audiofile

                    if (file != null && file.Length >= 0)
                    {
                        //using (var stream = new FileStream(appEnvironment.WebRootPath + filePath, FileAccess.Write))
                        //{
                        //    await file.CopyToAsync(stream);
                        //}
                        fileEntry.Name = file.FileName;
                        fileEntry.Url = filePath;
                    }
                }
            }

            return await _filesRepository.AddAsync(fileEntry);
        }

        public async Task<FileEntry> GetAsync(int id)
        {
            return await _filesRepository.GetFileByIdAsync(id);
        }
        public async Task<List<FileEntry>> GetFilesAsync()
        {
            return await _filesRepository.GetAllFilesAsync();
        }
    }
}
