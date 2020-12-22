using System;
using Database.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database.EFCore
{
    public partial class ExampleContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        
        public ExampleContext()
        {
        }

        public ExampleContext(DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;User ID=postgres;Password=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<ProductEntity>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<ProductEntity>().HasData(new
            {
                Id = 1,
                Code = "0001",
                Name = "Cool Product",
                CreationDate = new DateTime(2020, 1, 3),
                Quantity = 42
            });
            
            modelBuilder.Entity<ProductEntity>().HasData(new
            {
                Id = 2,
                Code = "0002",
                Name = "Not So Cool Product",
                CreationDate = new DateTime(2020, 1, 1),
                Quantity = 413
            });
            
            modelBuilder.Entity<ProductEntity>().HasData(new
            {
                Id = 3,
                Code = "0033",
                Name = "Very Cool Product",
                CreationDate = new DateTime(2020, 1, 2),
                Quantity = 92
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
