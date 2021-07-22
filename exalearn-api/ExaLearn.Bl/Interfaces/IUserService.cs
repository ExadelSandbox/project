using ExaLearn.Bl.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetAllAsync();

        public Task<UserDTO> GetByIdAsync(int id);

        public Task<UserHistoryDTO> GetUserHistoryByIdAsync(int id);

        public Task<HRHistoryDTO> GetHrUserHistoryByIdAsync(int id);
    }
}
