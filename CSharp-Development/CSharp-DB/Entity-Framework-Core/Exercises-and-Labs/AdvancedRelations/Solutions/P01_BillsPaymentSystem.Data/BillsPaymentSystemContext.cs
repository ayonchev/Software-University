using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data.EntityConfig;
using P01_BillsPaymentSystem.Data.Models;
using System;

namespace P01_BillsPaymentSystem.Data
{
    public class BillsPaymentSystemContext : DbContext
    {
        public BillsPaymentSystemContext()
        {
        }

        public BillsPaymentSystemContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new PaymentMethodConfiguration());
            builder.ApplyConfiguration(new BankAccountConfiguration());
            builder.ApplyConfiguration(new CreditCardConfiguration());
        }
    }
}
