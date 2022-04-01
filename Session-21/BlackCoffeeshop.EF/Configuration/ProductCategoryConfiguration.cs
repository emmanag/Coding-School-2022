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
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
          
                builder.ToTable("ProductCategories");

                builder.HasKey(productcategory => productcategory.ID);
                builder.Property(productcategory => productcategory.ID).ValueGeneratedOnAdd();

                builder.Property(productcategory => productcategory.Code).HasMaxLength(10);
                builder.Property(productcategory => productcategory.Description).HasMaxLength(30);
            //builder.Property(productcategory => productcategory.ProductType).HasMaxLength(30);


            //builder.HasOne(productcategory => productcategory.Transaction).WithOne(transaction => transaction.ProductCategory).HasForeignKey<Transaction>(transaction => transaction.ID);
            
        }
    }
}
