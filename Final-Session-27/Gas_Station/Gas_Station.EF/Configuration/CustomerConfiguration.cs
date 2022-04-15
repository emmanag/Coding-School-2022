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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(customer => customer.ID);
            //builder.Property(customer => customer.ID).ValueGeneratedOnAdd();

            builder.Property(customer => customer.Name).HasMaxLength(10);
            builder.Property(customer => customer.Surname).HasMaxLength(30);
            builder.Property(customer => customer.CardNumber).HasMaxLength(30);
            builder.HasIndex(customer => customer.CardNumber).IsUnique();

            builder.HasMany(customer => customer.Transaction)
                .WithOne(transaction => transaction.Customer)
                .HasForeignKey(transaction => transaction.CustomerID);

        }
    }
}
