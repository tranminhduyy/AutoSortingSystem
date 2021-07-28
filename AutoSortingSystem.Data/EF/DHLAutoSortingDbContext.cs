using AutoSortingSystem.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoSortingSystem.Data.EF
{
    public partial class DHLAutoSortingDbContext : DbContext
    {
        public DHLAutoSortingDbContext()
            : base("name=DHLAutoSortingDbContext")
        {
        }

        public virtual DbSet<Alarm> Alarms { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<DeviceManagement> DeviceManagements { get; set; }
        public virtual DbSet<GateRecipe> GateRecipes { get; set; }
        public virtual DbSet<RecipeManagement> RecipeManagements { get; set; }
        public virtual DbSet<ReportBarcode> ReportBarcodes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Wh_Management> Wh_Management { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alarm>()
                .Property(e => e.AlrmMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.EvUser)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.EvMessage)
                .IsUnicode(false);

            modelBuilder.Entity<DeviceManagement>()
                .Property(e => e.DeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<DeviceManagement>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<DeviceManagement>()
                .Property(e => e.Wh_Name)
                .IsUnicode(false);

            modelBuilder.Entity<GateRecipe>()
                .Property(e => e.Recipe_ID)
                .IsUnicode(false);

            modelBuilder.Entity<GateRecipe>()
                .Property(e => e.GateNo)
                .IsUnicode(false);

            modelBuilder.Entity<GateRecipe>()
                .Property(e => e.ReferenceCode)
                .IsUnicode(false);

            modelBuilder.Entity<RecipeManagement>()
                .Property(e => e.Recipe)
                .IsUnicode(false);

            modelBuilder.Entity<ReportBarcode>()
                .Property(e => e.Recipe)
                .IsUnicode(false);

            modelBuilder.Entity<Wh_Management>()
                .Property(e => e.Wh_Name)
                .IsUnicode(false);
        }
    }
}
