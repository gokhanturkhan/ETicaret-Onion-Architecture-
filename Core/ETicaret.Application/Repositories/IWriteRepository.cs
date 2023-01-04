using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddAsync(List<T> entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> RemoveAsync(string id);
        Task<bool> RemoveAsync(T entity);
    }
}
