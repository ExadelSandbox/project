using ExaLearn.Bl.DTO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IAudioFileService
    {
        Task<AudioFileDTO> CreateAsync(IFormFile file);

        Task<AudioFileDTO> GetByIdAsync(int id);

        Task<List<AudioFileDTO>> GetFilesAsync();
    }
}
