using AutoMapper;
using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _historyRepository;
        private readonly IMapper _mapper;

        public HistoryService(IHistoryRepository historyRepository, IMapper mapper)
        {
            _historyRepository = historyRepository;
            _mapper = mapper;
        }

        public async Task<HistoryDTO> CreateAsync(HistoryDTO historyDTO)
        {
            var history = _mapper.Map<History>(historyDTO);
            history = await _historyRepository.CreateAsync(history);
            return _mapper.Map<HistoryDTO>(history);
        }

        public async Task<HistoryDTO> GetByIdAsync(int id)
        {
            var history = await _historyRepository.GetByIdAsync(id);
            return _mapper.Map<HistoryDTO>(history);
        }

        public async Task<List<HistoryDTO>> GetAllAsync()
        {
            var history = await _historyRepository.GetAllAsync();
            return _mapper.Map<List<HistoryDTO>>(history);
        }
    }
}
