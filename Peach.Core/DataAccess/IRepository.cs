﻿using Peach.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Peach.Core.DataAccess
{
  public  interface IRepository<TEntity>
        where TEntity:BaseEntity
    {
        void Add (TEntity entity);
        void Update (TEntity entity);
        void Remove (TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] include);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] include);


    }
}
