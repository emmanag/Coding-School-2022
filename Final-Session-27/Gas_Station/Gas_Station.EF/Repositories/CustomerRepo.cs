using Gas_Station.EF.Context;
using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Gas_Station.EF.Repositories;

namespace Gas_Station.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly GasStationContext context;
        public CustomerRepo(GasStationContext dbCOntext)
        {
            context = dbCOntext;
        }

        public Task Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Customer entity)
        {
            if (entity.ID == Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await context.Customers.ToListAsync();
        }

        public Customer? GetById(Guid id)
        {
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public async Task<Customer?> GetByIdAsync(Guid id)
        {
            return await context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
        }

        public async Task Update(Guid id, Customer entity)
        {
            using var context = new GasStationContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.CardNumber = entity.CardNumber;
            

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id, Customer entity)
        {
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.CardNumber = entity.CardNumber;

            await context.SaveChangesAsync();
        }
    }
}
