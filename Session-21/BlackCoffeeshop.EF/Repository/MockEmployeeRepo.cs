﻿using BlackCoffeeshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.EF.Repository;

public class MockEmployeeRepo : IEntityRepo<Employee>
{
    private readonly List<Employee> _employees;
    public MockEmployeeRepo()
    {
        _employees = new List<Employee>
        {
            new Employee() {
                EmployeeType = EmployeeType.Cashier,
                Name = "Takis",
                Surname = "Papadakis",
                SalaryPerMonth = 900
            }
        };
    }
    /// <inheritdoc />
    public async Task Create(Employee entity)
    {
        _employees.Add(entity);
    }

    public Task CreateAsync(Employee entity) {
        throw new NotImplementedException();
    }

    public async Task Delete(int id)
    {
        _employees.Remove(GetById(id));
    }

    public Task DeleteAsync(int id) {
        throw new NotImplementedException();
    }

    public List<Employee> GetAll()
    {
        return _employees;
    }

    public Task<IEnumerable<Employee>> GetAllAsync() {
        throw new NotImplementedException();
    }

    public Employee? GetById(int id)
    {
        return _employees.SingleOrDefault(Employee => Employee.ID == id);
    }

    public Task<ProductCategory?> GetByIdAsync(int id) {
        throw new NotImplementedException();
    }

    public async Task Update(int id, Employee entity)
    {
        var foundEmployee = _employees.SingleOrDefault(Employee => Employee.ID == id);

        if (foundEmployee is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        foundEmployee.Name = entity.Name;
        foundEmployee.Surname = entity.Surname;
        foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
        foundEmployee.EmployeeType = entity.EmployeeType;

    }

    public Task UpdateAsync(int id, Employee entity) {
        throw new NotImplementedException();
    }
}