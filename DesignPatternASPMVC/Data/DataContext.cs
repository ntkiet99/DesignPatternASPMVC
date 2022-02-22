using System;
using System.Data.Entity;
using DesignPatternASPMVC.Models;

namespace DesignPatternASPMVC.Data
{
    public partial class DataContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public DataContext() : base("name=DPASPMVCConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().Property(e => e.Id).HasColumnName("id");
            modelBuilder.Entity<User>().Property(e => e.Password)
                    .HasMaxLength(1024)
                    .HasColumnName("password");
            modelBuilder.Entity<User>().Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
        }
    }
}
