using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IHistoryService
    {
        public Task<HistoryDTO> CreateAsync(HistoryDTO userDTO);

        public Task<HistoryDTO> GetByIdAsync(int id);

        public Task<List<HistoryDTO>> GetAllAsync();
    }
}
