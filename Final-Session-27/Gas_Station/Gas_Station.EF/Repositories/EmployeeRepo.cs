using Gas_Station.EF.Context;
using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Gas_Station.EF.Repositories;

namespace Gas_Station.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly GasStationContext context;
        public EmployeeRepo(GasStationContext dbCOntext)
        {
            context = dbCOntext;
        }
        public Task Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Employee entity)
        {
            if (entity.ID != Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Employees.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;

            context.Employees.Remove(foundEmployee);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            context.Employees.Remove(foundEmployee);
            await context.SaveChangesAsync();
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await context.Employees.ToListAsync();
        }

        public Employee? GetById(Guid id)
        {
            return context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
        }

        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
        }

        public async Task Update(Guid id, Employee entity)
        {
            using var context = new GasStationContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;

            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;            
            foundEmployee.HireDateEnd = entity.HireDateEnd;
            foundEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            foundEmployee.EmployeeType = entity.EmployeeType;


            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id, Employee entity)
        {
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;

            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.HireDateStart = entity.HireDateStart;
            foundEmployee.HireDateEnd = entity.HireDateEnd;
            foundEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            foundEmployee.EmployeeType = entity.EmployeeType;
        }
    }
}
