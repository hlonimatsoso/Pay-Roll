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
            this.context.SaveChanges();
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
            this.context.SaveChanges();
        }

        public virtual void Update(object id, TEntity entityToUpdate)
        {

            try
            {
                dbSet.Attach(entityToUpdate);
                var entry = this.context.Entry(entityToUpdate);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to update id: '{id}': Error: {ex.ToString()}");
                throw;
            }
    
        }

        public List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
    }
}
