namespace lab4
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=priceList")
        {
        }

        public virtual DbSet<lab8> lab8 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<lab8>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<lab8>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lab8>()
                .Property(e => e.Color)
                .IsUnicode(false);
        }
    }
}
