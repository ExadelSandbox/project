using ExaLearn.Bl.DTO;
using ExaLearn.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetAllAsync();

        public Task<UserDTO> GetAsync(int id);
    }
}
