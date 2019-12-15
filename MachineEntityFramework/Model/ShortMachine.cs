using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachineEntityFramework.EF;

namespace MachineEntityFramework.Model
{
    class ShortMachine
    {
        public int MachineId { get; set; }
        public string Producer { get; set; }
        public override string ToString() => $"{MachineId}, {Producer}";
    }
}
