using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;

namespace CoffeeShop.EF.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {
        public async Task Create(Employee entity) {
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

        public List<Employee> GetAll() {
            using var context = new ApplicationContext();
            return context.Employees.ToList();
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
    }
}
