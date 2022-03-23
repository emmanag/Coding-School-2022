using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Session_14.model;
using TodoApp.EF.Repositories;

namespace Session_14.App.Repositories
{
    public class CustomerRepository : IEntityRepo<Customer>
    {
        public async Task Create(Customer entity)
        {
            using var context = new Session_14Context();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new Session_14Context();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            using var context = new Session_14Context();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id)
        {
            using var context = new Session_14Context();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        

        public async Task Update(Guid id, Customer entity)
        {
            using var context = new Session_14Context();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;
            
            foundCustomer.Phone = entity.Phone;
            foundCustomer.TIN = entity.TIN;
            await context.SaveChangesAsync();
        }

        
    }
}
