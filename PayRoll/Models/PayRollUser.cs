using Microsoft.AspNetCore.Identity;
using PayRoll.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayRoll.Models
{
    public class PayRollUser : IdentityUser, IPayRollUser
    {
        [Key]
        public int PayRollUserID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Picture { get; set; }
        public int ManagerID { get; set; }

        [Required]
        public RoleLevel RoleLevel { get; set; }
    }
}
