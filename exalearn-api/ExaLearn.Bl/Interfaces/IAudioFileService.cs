using ExaLearn.Bl.DTO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IAudioFileService
    {
        public Task<AudioFileDTO> CreateAsync(IFormFile file);

        public Task<AudioFileDTO> GetByIdAsync(int id);

        public Task<List<AudioFileDTO>> GetFilesAsync();
    }
}
