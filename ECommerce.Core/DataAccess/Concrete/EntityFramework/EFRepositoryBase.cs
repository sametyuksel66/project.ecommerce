using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Core.Entities;
using ECommerce.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ECommerce.Core.DataAccess.BaseClasses.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext, TKey> : IEntityRepository<TEntity, TKey> where TEntity : class,IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public int Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State =  EntityState.Deleted;
                return context.SaveChanges();
            }
        }

        public int Delete(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext context = new TContext())
            {
                List<TEntity> DeletedItem = context.Set<TEntity>().Where(exp).ToList();
                context.RemoveRange(DeletedItem);
                return context.SaveChanges();
            }
        }

        

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).MyInclude(includes).SingleOrDefault(filter);
            }
        }

        public TEntity GetById(TKey id)
        {
            using(TContext context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().MyInclude(includes).ToList() :
                    context.Set<TEntity>().Where(filter).MyInclude(includes).ToList();
            }
        }


        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

}
