using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.Property(ba => ba.Balance)
                .IsRequired();

            builder.Property(ba => ba.BankName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(ba => ba.SwiftCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}
