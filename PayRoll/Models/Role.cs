using Microsoft.AspNetCore.Identity;
using PayRoll.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PayRoll.Models
{
    public class Role :IdentityRole,  IRole
    {
        [Required]
        public double Rate { get ; set ; }
    }
}
