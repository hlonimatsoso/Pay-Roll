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
            throw new System.NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> GetAll()
        {
            return this.Repo.GetAll() ;
        }

        public T GetByID(object id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entityToUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}