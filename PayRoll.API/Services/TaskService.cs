using PayRoll.Interfaces;
using PayRoll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayRoll.API.Services
{
    public class TaskService : BaseSevice<EmployeeTask>, ITaskService
    {

        public TaskService(IBaseRepository<EmployeeTask> repo) : base(repo)
        {
            this.Repo = repo;
        }


    }
}
