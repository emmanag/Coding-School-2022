using BlackCoffeeshop.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BlackCoffeeshop.Model;

namespace BlackCoffeeshop.EF.Configuration {
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(product => product.ID);
            builder.Property(product => product.ID).ValueGeneratedOnAdd();

            builder.Property(product => product.Code).HasMaxLength(10);
            builder.Property(product => product.Description).HasMaxLength(30);
            builder.Property(product => product.ProductCategoryID).HasMaxLength(10);
            builder.Property(product => product.Price).HasMaxLength(10);
            builder.Property(product => product.Cost).HasMaxLength(10);


            //builder.HasOne(product => product.Transaction).WithOne(transaction => transaction.Product).HasForeignKey<Transaction>(transaction => transaction.ID);
        }
    }
}
