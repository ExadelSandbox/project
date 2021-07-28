using ExaLearn.Dal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<string> GetUserRole();
    }
}
