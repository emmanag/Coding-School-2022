using BlackCoffeeshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.EF.Repository;

public class MockCustomerRepo : IEntityRepo<Customer>
{
    private readonly List<Customer> _customers;
    public MockCustomerRepo()
    {
        _customers = new List<Customer>
        {
             new Customer()
             {
                ID  = 1,
                Code = "000001",
                Description = "Retail"
             },

             new Customer()
             {
                ID = 2,
                Code = "000002",
                Description = "Retail"
             },
             new Customer()
             {
                ID=3,
                Code = "000003",
                Description = "Retail"
             }

        };

    }
    public Task Create(Customer entity)
    {
        throw new NotImplementedException();
    }
    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }
    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }
    public Customer? GetById(int id)
    {
        throw new NotImplementedException();
    }
    public Task Update(int id, Customer entity)
    {
        throw new NotImplementedException();
    }

    //ASYNC
    public Task CreateAsync(Customer entity)
    {
        _customers.Add(entity);

        return Task.CompletedTask;
    }
    public Task DeleteAsync(int id)
    {
        var foundCustomer = _customers.SingleOrDefault(c => c.ID == id);
        if (foundCustomer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        _customers.Remove(foundCustomer);

        return Task.CompletedTask;
    }

    public IEnumerable<Customer> Get_customers()
    {
        return _customers;
    }

    public Task<IEnumerable<Customer>> GetAllAsync(IEnumerable<Customer> _customers)
    {
        return Task.FromResult(_customers.AsEnumerable());
    }
    public Task<Customer?> GetByIdAsync(int id)
    {
        return Task.FromResult(_customers.SingleOrDefault(customer => customer.ID == id));
    }
    public Task UpdateAsync(int id, Customer entity)
    {
        var foundCustomer = _customers.SingleOrDefault(todo => todo.ID == id);
        if (foundCustomer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        foundCustomer.Code = entity.Code;
        foundCustomer.Description = entity.Description;

        return Task.CompletedTask;
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return  _customers;
    }


}
