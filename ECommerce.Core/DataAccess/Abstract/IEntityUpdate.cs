using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.DataAccess.Abstract
{
    public interface IEntityUpdate<TEntity> where TEntity : class, IEntity, new()
    {
        void Update(TEntity entity);
    }
}
