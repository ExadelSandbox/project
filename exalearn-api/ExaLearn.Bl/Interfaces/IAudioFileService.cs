using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IAudioFileService
    {
        Task<AudioFileDTO> CreateAsync(string url);

        Task<AudioFileDTO> GetByIdAsync(int id);

        Task<List<AudioFileDTO>> GetFilesAsync();
    }
}
