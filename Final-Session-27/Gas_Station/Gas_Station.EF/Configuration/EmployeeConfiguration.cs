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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employeess");
            builder.HasKey(employee => employee.ID);
            //builder.Property(employee => employee.ID).ValueGeneratedOnAdd();

            builder.Property(employee => employee.Name).HasMaxLength(10);
            builder.Property(employee => employee.Surname).HasMaxLength(30);            
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(10, 3);
            builder.Property(employee => employee.EmployeeType).HasConversion(employeeType => employeeType.ToString(),
                            employeeType => (EmployeeType)Enum.Parse(typeof(EmployeeType), employeeType)).HasMaxLength(20);

            builder.HasMany(employee => employee.Transaction)
                .WithOne(transaction => transaction.Employee)
                .HasForeignKey(transaction => transaction.EmployeeID);
        }
    }
}
