﻿using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<T> GetSingleAsync(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> filter);

        Task<T> GetByIdAsync(string id);


    }
}
