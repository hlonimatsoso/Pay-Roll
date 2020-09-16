using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayRoll.API.Services;
using PayRoll.Interfaces;
using PayRoll.Models;


namespace PayRoll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        ITaskService _service;

        public TasksController(ITaskService service)
        {
            this._service = service;
        }


        [HttpGet]
        public IEnumerable<EmployeeTask> Get()
        {
            return this._service.GetAll();
        }

        [HttpGet("{id}")]
        public EmployeeTask Get(int id)
        {
            return this._service.GetByID(id);
        }

        [HttpPost]
        public void Post([FromBody] NewEmployeeTask task)
        {
            this._service.Insert(new EmployeeTask { TaskName = task.Name, TaskDuration = task.Duration, PayRollUserID = task.AssignedTo == null ? 0 : (int)task.AssignedTo });
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeTask task)
        {
            this._service.Update(id,task);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._service.Delete(id);
        }
    }
}
