using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T item);

        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<T> DeleteAsync(T item);

        Task<T> UpdateAsync(T item);

        Task<IList<T>> AddRange(IList<T> item);
    }
}
