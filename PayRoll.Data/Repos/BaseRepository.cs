using Microsoft.EntityFrameworkCore;
using PayRoll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayRoll.Data.Repos
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        internal PayRollDBContext context;
        internal DbSet<TEntity> dbSet;

        public BaseRepository()
        { }

        public BaseRepository(PayRollDBContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }


        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
    }
}
