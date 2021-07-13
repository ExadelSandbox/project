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
        public Task<User> AddAsync(User user);

        public Task<List<User>> GetAllAsync();

        public Task<User> GetAsync(int id);

        public Task<User> Remove(User user);

        public Task<User> Update(User user);
    }
}
