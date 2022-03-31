﻿using System.Text.Json.Serialization;

namespace BlackCoffeeshop.Model
{
    public class Employee
    {
        public Guid ID { get; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Surname { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public decimal SalaryPerMonth { get; set; }

        public Employee()
        {
        }

        
    }
}
