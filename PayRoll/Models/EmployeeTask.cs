using PayRoll.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PayRoll.Models
{
    public class EmployeeTask : IEmployeeTask
    {
        [Key]
        public int EmployeeTaskID { get ; set ; }

        [Required]
        public string TaskName { get ; set ; }
        
        [Required]
        public double TaskDuration { get ; set ; }
        
        public int CompletedBy { get ; set ; }
        
        public double UserRateAtCompletionTime { get ; set ; }
        
        public DateTime DateOfCompletion { get ; set ; }

        //[ForeignKey("PayRollUser")]
        //public int PayRollUserID { get ; set ; }
        
        public PayRollUser PayRollUser { get ; set ; }
    }
}
