namespace MachineEntityFramework.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Machine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Machine()
        {
            Repairs = new HashSet<Repair>();
        }

        public int id { get; set; }

        [StringLength(45)]
        public string producer { get; set; }

        [StringLength(7)]
        public string machineType { get; set; }

        public double? price { get; set; }

        public int? flops { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Repair> Repairs { get; set; }
    }
}
