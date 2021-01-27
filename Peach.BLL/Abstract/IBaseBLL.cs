using Peach.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.BLL.Abstract
{
   public interface IBaseBLL<TEntity>
        where TEntity:BaseEntity
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteByID(int entityid);
        TEntity Get(int entityid);
        ICollection<TEntity> GetAll();
    }
}
