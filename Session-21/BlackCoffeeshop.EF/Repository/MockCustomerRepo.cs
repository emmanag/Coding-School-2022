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
    /// <inheritdoc />
    public IEnumerable<Customer> GetAll()
    {
        return _customers;
    }

    public Task<IEnumerable<Customer>> GetAllAsync()
    {
        return Task.FromResult(_customers.AsEnumerable());
    }

    /// <inheritdoc />
    public Customer? GetById(int id)
    {
        return _customers.SingleOrDefault(customer => customer.ID == id);
    }

    public Task<Customer?> GetByIdAsync(int id)
    {
        return Task.FromResult(_customers.SingleOrDefault(customer => customer.ID == id));
    }



    List<Customer> IEntityRepo<Customer>.GetAll()
    {
        return _customers;
    }

    public async Task Create(Customer entity)
    {
        if (entity.ID != 0)
            throw new ArgumentException("Given entity should not have Id set", nameof(entity));

        var lastId = _customers.OrderBy(customer => customer.ID).Last().ID;
        entity.ID = ++lastId;
        _customers.Add(entity);

    }

    public async Task Update(int id, Customer entity)
    {
        var foundcustomer = _customers.SingleOrDefault(customer => customer.ID == id);
        if (foundcustomer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        foundcustomer.Description = entity.Description;
        foundcustomer.Code = entity.Code;
    }



    public async Task Delete(int id)
    {
        var foundcustomer = _customers.SingleOrDefault(customer => customer.ID == id);
        if (foundcustomer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        _customers.Remove(foundcustomer);
    }
}
