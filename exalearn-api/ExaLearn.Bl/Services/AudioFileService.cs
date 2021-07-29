using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ExaLearn.Dal.Interfaces;
using AutoMapper;
using ExaLearn.Bl.DTO;

namespace ExaLearn.Bl.Services
{
    public class AudioFileService : IAudioFileService
    {
        private readonly IAudioFileRepository _audioFileRepository;
        private readonly IMapper _mapper;

        public AudioFileService(IAudioFileRepository audioFileRepository, IMapper mapper)
        {
            _audioFileRepository = audioFileRepository;
            _mapper = mapper;
        }

        public async Task<AudioFileDTO> CreateAsync(AudioFileDTO audioFileDTO)
        {
            var audioFile = _mapper.Map<AudioFile>(audioFileDTO);
            audioFile = await _audioFileRepository.CreateAsync(audioFile);
            return _mapper.Map<AudioFileDTO>(audioFile);
        }

        public async Task<AudioFileDTO> GetByIdAsync(int id)
        {
            var file = await _audioFileRepository.GetByIdAsync(id);
            return _mapper.Map<AudioFileDTO>(file);
        }

        public async Task<List<AudioFileDTO>> GetFilesAsync()
        {
            var file = await _audioFileRepository.GetAllAsync();
            return _mapper.Map<List<AudioFileDTO>>(file);
        }
    }
}
