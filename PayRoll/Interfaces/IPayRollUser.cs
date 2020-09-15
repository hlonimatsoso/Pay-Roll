//using Microsoft.AspNet.Identity.EntityFramework;
using PayRoll.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayRoll.Interfaces
{
    public interface IPayRollUser
    {
       
        public int PayRollUserID { get; set; }

       
        string Name { get; set; }

        public string Picture { get; set; }

        
        public int ManagerID { get; set; }

        //public List<IEmployeeTask> Tasks { get; set; }

      
        public  RoleLevel RoleLevel { get; set; }
    }
}
