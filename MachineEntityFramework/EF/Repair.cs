namespace MachineEntityFramework.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Repair
    {
        public int repairId { get; set; }

        public int? machineId { get; set; }

        public int? typeId { get; set; }

        public virtual Machine Machine { get; set; }

        public virtual MachineType MachineType { get; set; }
    }
}
