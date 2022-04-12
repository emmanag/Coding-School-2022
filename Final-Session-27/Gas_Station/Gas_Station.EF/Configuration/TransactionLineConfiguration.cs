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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");
            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.ID).ValueGeneratedOnAdd();

            builder.Property(transactionLine => transactionLine.TransactionID).HasMaxLength(10);
            builder.Property(transactionLine => transactionLine.ItemID).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.Quantity).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.ItemPrice).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.NetValue).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.DiscountPercent).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.DiscountValue).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.TotalValue).HasMaxLength(30);
        }
    }
}
