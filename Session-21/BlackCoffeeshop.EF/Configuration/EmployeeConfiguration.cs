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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();

            builder.Property(employee => employee.Name).HasMaxLength(10);
            builder.Property(employee => employee.Surname).HasMaxLength(30);
            builder.Property(employee => employee.EmployeeType).HasMaxLength(30);
            builder.Property(employee => employee.SalaryPerMonth).HasMaxLength(30);


            builder.HasOne(employee => employee.Transaction).WithOne(transaction => transaction.Employee).HasForeignKey<Transaction>(transaction => transaction.ID);
        }
    }
}
