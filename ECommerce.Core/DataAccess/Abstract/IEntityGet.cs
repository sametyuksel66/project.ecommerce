using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.Core.DataAccess.Abstract
{
    public interface IEntityGet<TEntity> where TEntity : class, IEntity, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity,object>>[] includes);
    }
}
