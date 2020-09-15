using PayRoll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Data.Repos
{
    public class TaskRepo : BaseRepository<IEmployeeTask>, IBaseRepository<IEmployeeTask>, ITaskRepo
    {
    }
}
