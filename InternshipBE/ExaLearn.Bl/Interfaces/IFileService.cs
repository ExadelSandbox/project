using ExaLearn.Dal.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IFileService
    {
        public Task<FileEntry> AddAsync(IFormFile file);

        public Task<FileEntry> GetAsync(FileEntry fileEntry);

        public Task<List<FileEntry>> GetFilesAsync();
    }
}
