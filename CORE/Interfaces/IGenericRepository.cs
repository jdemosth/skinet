using CORE.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CORE.Interfaces
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<T> GetbyIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
    }
}
