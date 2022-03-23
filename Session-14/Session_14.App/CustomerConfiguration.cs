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
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.Surname).HasMaxLength(12);
            builder.Property(customer => customer.TIN).HasMaxLength(12);
            builder.Property(customer => customer.Phone).HasMaxLength(12);
            builder.Property(customer => customer.Name).HasMaxLength(12);
            

        }
    }
}
