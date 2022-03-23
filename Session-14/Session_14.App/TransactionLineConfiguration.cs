using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_14.model;

namespace Session_14.App
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.Property(transactionLine => transactionLine.TransactionID).HasMaxLength(12);
            builder.Property(transactionLine => transactionLine.ServiceTaskID).HasMaxLength(12);
            builder.Property(transactionLine => transactionLine.EngineerID).HasMaxLength(12);
            builder.Property(transactionLine => transactionLine.Hours).HasMaxLength(12);
            builder.Property(transactionLine => transactionLine.PricePerHour).HasMaxLength(12);
            builder.Property(transactionLine => transactionLine.Price).HasMaxLength(12);
            builder.HasOne(transactionLine => transactionLine.Transaction)
                .WithMany(transaction => transaction.TransactionLines)
                .HasForeignKey(transactionLine => transactionLine.TransactionID);
        }
    }
}