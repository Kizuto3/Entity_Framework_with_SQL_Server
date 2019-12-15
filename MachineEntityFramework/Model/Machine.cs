using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineEntityFramework.EF
{
    public partial class Machine
    {
        public override string ToString()
        {
            return $"{this.id}, {producer}, {machineType}, {price}, {flops}";
        }
    }
}
