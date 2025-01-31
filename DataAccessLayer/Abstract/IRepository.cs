﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        Task Create(T p);
        IQueryable<T> List { get; }
        IQueryable<T> Include(params Expression<Func<T, object>>[] includes);
        Task Update(T p);
        Task Delete(T p);
    }
}
