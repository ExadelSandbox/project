using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T item);

        Task<T> GetAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<T> Remove(T item);

        Task<T> Update(T item);
    }
}
