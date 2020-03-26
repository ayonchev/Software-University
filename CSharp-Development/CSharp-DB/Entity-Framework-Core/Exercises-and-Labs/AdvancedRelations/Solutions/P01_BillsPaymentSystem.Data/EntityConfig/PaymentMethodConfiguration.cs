using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasIndex(pm => new { pm.UserId, pm.CreditCardId, pm.BankAccountId }).IsUnique();

            builder.HasOne(pm => pm.User)
                .WithMany(u => u.PaymentMethods)
                .HasForeignKey(pm => pm.UserId);

            builder.HasOne(pm => pm.BankAccount)
                .WithOne(ba => ba.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);

            builder.HasOne(pm => pm.CreditCard)
                .WithOne(cc => cc.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);
        }
    }
}
