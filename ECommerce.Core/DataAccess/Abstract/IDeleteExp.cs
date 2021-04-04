using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.Core.DataAccess.Abstract
{
    public interface IDeleteExp<TEntity> where TEntity : class, IEntity, new()
    {
        int Delete(Expression<Func<TEntity, bool>> exp);
    }
}
