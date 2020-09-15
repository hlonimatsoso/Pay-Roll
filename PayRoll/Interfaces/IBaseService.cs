using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Interfaces
{
    public interface IBaseSevice<T> :IBaseRepository<T> where T : class
    {
        public IBaseRepository<T> Repo { get; set; }

    }
}
