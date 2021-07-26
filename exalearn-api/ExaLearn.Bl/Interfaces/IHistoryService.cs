using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IHistoryService
    {
        Task<HistoryDTO> CreateAsync(HistoryDTO userDTO);

        Task<HistoryDTO> GetByIdAsync(int id);

        Task<List<HistoryDTO>> GetAllAsync();
    }
}
