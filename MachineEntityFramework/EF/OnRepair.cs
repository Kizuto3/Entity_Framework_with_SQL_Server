namespace MachineEntityFramework.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OnRepair
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(45)]
        public string producer { get; set; }

        [StringLength(7)]
        public string type { get; set; }

        public double? price { get; set; }

        public int? flops { get; set; }
    }
}
