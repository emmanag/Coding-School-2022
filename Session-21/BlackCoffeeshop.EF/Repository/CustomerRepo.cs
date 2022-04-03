using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;

namespace CoffeeShop.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public async Task Create(Customer entity) {
            using var context = new ApplicationContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public Task CreateAsync(Customer entity) {
            throw new NotImplementedException();
        }

        public async Task Delete(int id) {
            using var context = new ApplicationContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id) {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll() {
            using var context = new ApplicationContext();
            return context.Customers.ToList();
        }

        public Task<IEnumerable<Customer>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Customer? GetById(int id) {
            using var context = new ApplicationContext();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public Task<ProductCategory?> GetByIdAsync(int id) {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Customer entity) {
            using var context = new ApplicationContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Code = entity.Code;
            foundCustomer.Description = entity.Description;
            foundCustomer.Transaction = entity.Transaction;

            await context.SaveChangesAsync();
        }

        public Task UpdateAsync(int id, Customer entity) {
            throw new NotImplementedException();
        }
    }
}
