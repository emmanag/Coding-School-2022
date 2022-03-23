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
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.Date).HasMaxLength(15);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(15);
            builder.Property(transaction => transaction.CarID).HasMaxLength(15);
            builder.Property(transaction => transaction.ManagerID).HasMaxLength(15);
            builder.Property(transaction => transaction.TotalPrice).HasMaxLength(12);
            
            
        }
    }
}
