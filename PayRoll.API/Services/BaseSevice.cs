using PayRoll.Interfaces;
using System.Collections.Generic;

namespace PayRoll.API.Services
{
    public class BaseSevice<T> : IBaseSevice<T> where T : class
    {

        public BaseSevice(IBaseRepository<T> repo)
        {
            this.Repo = repo;
        }

        public IBaseRepository<T> Repo { get; set; }

        public void Delete(T entityToDelete)
        {
            this.Repo.Delete(entityToDelete);
        }

        public void Delete(object id)
        {
            this.Repo.Delete(id);
        }

        public List<T> GetAll()
        {
            return this.Repo.GetAll() ;
        }

        public T GetByID(object id)
        {
            return this.Repo.GetByID(id);
        }

        public void Insert(T entity)
        {
            this.Repo.Insert(entity);
        }

        public void Update(object id, T entityToUpdate)
        {
            this.Repo.Update(id, entityToUpdate);
        }
    }
}