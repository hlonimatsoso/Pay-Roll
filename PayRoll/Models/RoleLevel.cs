using PayRoll.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayRoll.Models
{
    public class RoleLevel : IRoleLevel
    {
        [Key]
        public int RoleLevelID { get; set; }

        [Required]
        public double Rate { get ; set ; }
    }
}
