using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {
        private readonly ApplicationContext context;
        public EmployeeRepo(ApplicationContext dbCOntext)
        {
            context = dbCOntext;
        }
        public async Task Create(Employee entity) {
            using var context = new ApplicationContext();
            context.Employees.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task CreateAsync(Employee entity) {
            using var context = new ApplicationContext();
            context.Employees.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id) {
            using var context = new ApplicationContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;

            context.Employees.Remove(foundEmployee);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            var dbEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (dbEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Employees.Remove(dbEmployee);

            await context.SaveChangesAsync();
        }

        public List<Employee> GetAll() {
            using var context = new ApplicationContext();
            return context.Employees.ToList();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync() {
            return await context.Employees.ToListAsync();
        }

        public Employee? GetById(int id) {
            using var context = new ApplicationContext();
            return context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
        }

       

        public async Task Update(int id, Employee entity) {
            using var context = new ApplicationContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;

            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            foundEmployee.EmployeeType = entity.EmployeeType;
            foundEmployee.Transaction = entity.Transaction;

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Employee entity) {
            var dbEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (dbEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            dbEmployee.Name = entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;
            dbEmployee.Transaction = entity.Transaction;

            await context.SaveChangesAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
        }
    }
}
