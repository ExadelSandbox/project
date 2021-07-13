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
        public async Task<User> AddAsync(User user)
        {
            return await _genericRepository.AddAsync(user);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<User> GetAsync(int id)
        {
            return await _genericRepository.GetAsync(id);
        }

        public async Task<User> Remove(User user)
        {
            return await _genericRepository.Remove(user);
        }

        public async Task<User> Update(User user)
        {
            return await _genericRepository.Update(user);
        }
    }
}
