using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.Ignore(cc => cc.LimitLeft);

            builder.Property(cc => cc.Limit)
                .IsRequired();

            builder.Property(cc => cc.MoneyOwed)
                .IsRequired();
        }
    }
}
