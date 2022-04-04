using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly ApplicationContext context;
        public CustomerRepo(ApplicationContext dbCOntext)
        {
            context = dbCOntext;
        }


        public async Task CreateAsync(Customer entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public Task Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
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
            return  await context.Customers.ToListAsync();
        }

        public Customer? GetById(int id)
        {

            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await context.Customers.SingleOrDefaultAsync(prodCat => prodCat.ID == id);

        }

        public async Task Update(int id, Customer entity)
        {
            using var context = new ApplicationContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Code = entity.Code;
            foundCustomer.Description = entity.Description;
            foundCustomer.Transaction = entity.Transaction;

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Customer entity)
        {
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Code = entity.Code;
            foundCustomer.Description = entity.Description;
            foundCustomer.Transaction = entity.Transaction;

            await context.SaveChangesAsync();
        }

    }
}
