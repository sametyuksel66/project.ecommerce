using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.DataAccess.Abstract
{
    public interface IEntityDelete<TEntity> where TEntity : class, IEntity, new()
    {
        int Delete(TEntity entity);

    }
}
