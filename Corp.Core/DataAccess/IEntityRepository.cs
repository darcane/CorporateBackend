﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Corp.Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetList(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}