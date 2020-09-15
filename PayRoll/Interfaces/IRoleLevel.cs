using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Interfaces
{
    public interface IRoleLevel : IRate
    {
        public int RoleLevelID { get; set; }
    }
}
