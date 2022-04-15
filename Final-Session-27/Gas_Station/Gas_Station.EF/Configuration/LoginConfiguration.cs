using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.EF.Configuration
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(user => user.ID);
            builder.Property(user => user.ID).ValueGeneratedOnAdd();

            builder.HasIndex(user => user.Username).IsUnique();
            builder.Property(user => user.EmployeeType).HasConversion(x=> x.ToString(), x=> (EmployeeType)Enum.Parse(typeof(EmployeeType), x));
        }
    }
}
