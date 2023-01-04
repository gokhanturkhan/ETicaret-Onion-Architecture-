using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);

    }
}
