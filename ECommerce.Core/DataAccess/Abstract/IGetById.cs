using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.Core.DataAccess.Abstract
{
    interface IGetById<TEntity, TId> where TEntity:class, IEntity, new()
    {
        TEntity GetById(TId id, params Expression<Func<TEntity, object>>[] includes);
    }
}
