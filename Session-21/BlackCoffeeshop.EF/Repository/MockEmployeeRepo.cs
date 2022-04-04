using BlackCoffeeshop.Model;
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
        _employees.Add(entity);
        return Task.CompletedTask;
    }

    public async Task Delete(int id)
    {
        _employees.Remove(GetById(id));
    }

    public Task DeleteAsync(int id) {

        var foundEmployee = _employees.SingleOrDefault(Employee => Employee.ID == id);
        if (foundEmployee is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        _employees.Remove(foundEmployee);


        return Task.CompletedTask;
    }

    public List<Employee> GetAll()
    {
        return _employees;
    }

    public async Task<IEnumerable<Employee>> GetAllAsync() {
        return _employees;
    }

    public Employee GetById(int id)
    {
        return _employees.SingleOrDefault(employee => employee.ID == id);
    }

    public Task<Employee?> GetByIdAsync(int id) {
        return Task.FromResult(_employees.SingleOrDefault(employee => employee.ID == id));
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
        var foundEmployee = _employees.SingleOrDefault(Employee => Employee.ID == id);

        if (foundEmployee is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        foundEmployee.Name = entity.Name;
        foundEmployee.Surname = entity.Surname;
        foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
        foundEmployee.EmployeeType = entity.EmployeeType;

        return Task.CompletedTask;
    }

    
}
