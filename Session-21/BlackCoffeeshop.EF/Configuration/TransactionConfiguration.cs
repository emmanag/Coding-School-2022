using BlackCoffeeshop.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BlackCoffeeshop.Model;

namespace BlackCoffeeshop.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {

            builder.ToTable("Transactions");

            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).ValueGeneratedOnAdd();
            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(10);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(10);
            builder.Property(transaction => transaction.Date);
            builder.Property(transaction => transaction.PaymentMethod);
            builder.Property(transaction => transaction.TotalPrice);

        }
    }
}
