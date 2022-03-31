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
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");

            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.ID).ValueGeneratedOnAdd();
            builder.Property(transactionLine => transactionLine.ProductID).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.Quantity).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.Price).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.Discount).HasMaxLength(30);
            builder.Property(transactionLine => transactionLine.TotalPrice).HasMaxLength(30);

            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transactionLine => transactionLine.TransactionID);
        }
    }
}
