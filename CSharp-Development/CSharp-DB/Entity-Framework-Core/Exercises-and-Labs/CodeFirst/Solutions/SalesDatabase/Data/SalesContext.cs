using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext()
        {
        }

        public SalesContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Sales;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>(entity =>
            {
                entity.Property(p => p.Name)
                    .HasMaxLength(50);

                entity.Property(p => p.Description)
                    .HasMaxLength(250)
                    .HasDefaultValue("No description");
            });

            builder.Entity<Customer>(entity =>
            {
                entity.Property(c => c.Name)
                    .HasMaxLength(100);

                entity.Property(c => c.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            builder.Entity<Store>(entity =>
            {
                entity.Property(s => s.Name)
                    .HasMaxLength(80);
            });

            builder.Entity<Sale>(entity =>
            {
                entity.Property(s => s.Date)
                    .HasDefaultValueSql("GETDATE()");

                entity.HasOne(s => s.Product)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(s => s.ProductId);

                entity.HasOne(s => s.Customer)
                    .WithMany(c => c.Sales)
                    .HasForeignKey(s => s.CustomerId);

                entity.HasOne(sale => sale.Store)
                    .WithMany(store => store.Sales)
                    .HasForeignKey(sale => sale.StoreId);
            });
        }
    }
}
