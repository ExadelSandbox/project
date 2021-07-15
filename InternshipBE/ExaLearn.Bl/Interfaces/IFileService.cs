using ExaLearn.Dal.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IFileService
    {
        public Task<AudioFile> AddAsync(IFormFile file);

        public Task<AudioFile> GetAsync(int id);

        public Task<List<AudioFile>> GetFilesAsync();
    }
}
