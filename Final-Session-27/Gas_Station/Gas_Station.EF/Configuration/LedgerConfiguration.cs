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
            //builder.Property(ledger => ledger.ID).ValueGeneratedOnAdd();

            builder.Property(ledger => ledger.Year).HasPrecision(10, 3);
            builder.Property(ledger => ledger.Month).HasPrecision(10, 3);
            builder.Property(ledger => ledger.Income).HasPrecision(10, 3);
            builder.Property(ledger => ledger.Expenses).HasPrecision(10, 3);
            builder.Property(ledger => ledger.Total).HasPrecision(10, 3);
        }
    }
}
