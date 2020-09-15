using PayRoll.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Interfaces
{
    public interface IEmployeeTask
    {
        public int EmployeeTaskID { get; set; }

        public string TaskName { get; set; }

        public double TaskDuration { get; set; }

       // public int PayRollUserID { get; set; }

        public PayRollUser PayRollUser { get; set; }

        public double UserRateAtCompletionTime { get; set; }

        public DateTime DateOfCompletion { get; set; }

    }
}
