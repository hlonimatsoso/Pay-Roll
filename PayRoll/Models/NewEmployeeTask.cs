using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Models
{
    public class NewEmployeeTask
    {
        public string Name { get; set; }

        public double Duration { get; set; }

        public int? AssignedTo { get; set; }

    }
}
