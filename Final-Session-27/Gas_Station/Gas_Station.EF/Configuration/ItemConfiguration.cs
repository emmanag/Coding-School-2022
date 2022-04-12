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
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(item => item.ID);
            builder.Property(item => item.ID).ValueGeneratedOnAdd();

            builder.Property(item => item.Code).HasMaxLength(10);
            builder.Property(item => item.Description).HasMaxLength(30);
            builder.Property(item => item.ItemType).HasMaxLength(30);
            builder.Property(item => item.Price).HasMaxLength(10);
            builder.Property(item => item.Cost).HasMaxLength(10);

        }
    }
}
