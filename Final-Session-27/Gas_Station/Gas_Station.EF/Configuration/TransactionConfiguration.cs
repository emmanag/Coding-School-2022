using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gas_Station.EF.Context;

namespace Gas_Station.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).ValueGeneratedOnAdd();

            builder.Property(transaction => transaction.Date).HasMaxLength(10);
            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(30);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(30);
            builder.Property(transaction => transaction.PaymentMethod).HasMaxLength(30);
            builder.Property(transaction => transaction.TotalValue).HasMaxLength(30);
        }
    }
}
