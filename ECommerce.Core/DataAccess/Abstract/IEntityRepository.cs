using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.Core.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity, TKey>: IEntityAdd<TEntity>, 
        IEntityDelete<TEntity>,
        IEntityUpdate<TEntity>, 
        IEntityGet<TEntity>, 
        IEntityGetAll<TEntity>,
        IDeleteExp<TEntity>
        //IGetById<TEntity,TKey>
        where TEntity:class,IEntity,new()
    {
        

    }
}
