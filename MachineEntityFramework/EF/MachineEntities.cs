namespace MachineEntityFramework.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MachineEntities : DbContext
    {
        public MachineEntities()
            : base("name=MachineConnection")
        {
        }

        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MachineType> MachineTypes { get; set; }
        public virtual DbSet<OnRepair> OnRepairs { get; set; }
        public virtual DbSet<Repair> Repairs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Machine>()
                .Property(e => e.producer)
                .IsUnicode(false);

            modelBuilder.Entity<Machine>()
                .Property(e => e.machineType)
                .IsUnicode(false);

            modelBuilder.Entity<MachineType>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<MachineType>()
                .HasMany(e => e.Repairs)
                .WithOptional(e => e.MachineType)
                .HasForeignKey(e => e.typeId);

            modelBuilder.Entity<OnRepair>()
                .Property(e => e.producer)
                .IsUnicode(false);

            modelBuilder.Entity<OnRepair>()
                .Property(e => e.type)
                .IsUnicode(false);
        }
    }
}
