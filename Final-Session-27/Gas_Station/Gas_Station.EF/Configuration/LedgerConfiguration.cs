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
    internal class LedgerConfiguration : IEntityTypeConfiguration<Ledger>
    {
        public void Configure(EntityTypeBuilder<Ledger> builder)
        {
            builder.ToTable("Ledgers");
            builder.HasKey(ledger => ledger.ID);
            builder.Property(ledger => ledger.ID).ValueGeneratedOnAdd();

            builder.Property(ledger => ledger.Year).HasMaxLength(10);
            builder.Property(ledger => ledger.Month).HasMaxLength(30);
            builder.Property(ledger => ledger.Income).HasMaxLength(30);
            builder.Property(ledger => ledger.Expenses).HasMaxLength(30);
            builder.Property(ledger => ledger.Total).HasMaxLength(30);
        }
    }
}
