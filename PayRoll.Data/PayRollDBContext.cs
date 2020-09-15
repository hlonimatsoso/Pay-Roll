using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayRoll.Interfaces;
using PayRoll.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Data
{
    public class PayRollDBContext : IdentityDbContext<PayRollUser>
    {
        public PayRollDBContext(DbContextOptions<PayRollDBContext> options)
      : base(options)
        {
        }

        public DbSet<EmployeeTask> Tasks { get; set; }

        public DbSet<RoleLevel> RoleLevels { get; set; }



    }
}
