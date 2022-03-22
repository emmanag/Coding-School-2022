using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_14.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Session_14.App
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(car => car.Brand).HasMaxLength(12);
            builder.Property(car => car.Model).HasMaxLength(12);
            builder.Property(car => car.CarRegNumber).HasMaxLength(12);
        }
    }
}