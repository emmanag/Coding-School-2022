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
    internal class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.Property(engineer => engineer.ManagerID).HasMaxLength(12);
            builder.Property(engineer => engineer.SallaryPerMonth).HasMaxLength(12);
            builder.Property(engineer => engineer.Status).HasMaxLength(12);
        }
    }
}
