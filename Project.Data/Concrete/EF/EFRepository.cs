using Microsoft.EntityFrameworkCore;
using Project.Data.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Project.Data.Concrete.EF
{
    public class EFRepository<TEntity, TContext> : IRepository<TEntity>
                 where TEntity : class
                 where TContext : DbContext, new()
    {
        public bool Create(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                return context.SaveChanges() > 0;
            }
        }

        public bool Edit(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }
    }
}
