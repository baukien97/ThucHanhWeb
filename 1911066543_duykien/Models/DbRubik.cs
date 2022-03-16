using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _1911066543_duykien.Models
{
    public partial class DbRubik : DbContext
    {
        public DbRubik()
            : base("name=DbRubik")
        {
        }

        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<Rubik> Rubiks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rubik>()
                .Property(e => e.gia)
                .HasPrecision(18, 0);
        }
    }
}
