using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Entities;
using ExaLearn.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;

        public UserService(IGenericRepository<User> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<User> GetAsync(int id)
        {
            return await _genericRepository.GetAsync(id);
        }
    }
}
