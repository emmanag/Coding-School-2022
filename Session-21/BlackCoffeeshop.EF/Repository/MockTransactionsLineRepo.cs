using BlackCoffeeshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.EF.Repository;

public class MockTransactionLineRepo : IEntityRepo<TransactionLine>
{
    private readonly List<TransactionLine> _transactionLines;

    public MockTransactionLineRepo()
    {
        _transactionLines = new List<TransactionLine>
        {
            new TransactionLine() { ID = 1, TransactionID = 1, Quantity = 1,
            Price = 1.2m, ProductID = 1, Discount = 0.15m, TotalPrice = 10
            }

        };
    }

    /// <inheritdoc />
    public IEnumerable<TransactionLine> GetAll()
    {
        return _transactionLines;
    }

    public Task<IEnumerable<TransactionLine>> GetAllAsync()
    {
        return Task.FromResult(_transactionLines.AsEnumerable());
    }

    /// <inheritdoc />
    public TransactionLine? GetById(int id)
    {
        return _transactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
    }

    public Task<TransactionLine?> GetByIdAsync(int id)
    {
        return Task.FromResult(_transactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id));
    }



    List<TransactionLine> IEntityRepo<TransactionLine>.GetAll()
    {
        return _transactionLines;
    }

    public async Task Create(TransactionLine entity)
    {
        if (entity.ID != 0)
            throw new ArgumentException("Given entity should not have Id set", nameof(entity));

        var lastId = _transactionLines.OrderBy(transactionLine => transactionLine.ID).Last().ID;
        entity.ID = ++lastId;
        _transactionLines.Add(entity);

    }

    public async Task Update(int id, TransactionLine entity)
    {
        var foundtransactionLine = _transactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
        if (foundtransactionLine is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        foundtransactionLine.Quantity = entity.Quantity;
        foundtransactionLine.TotalPrice = entity.TotalPrice;
        foundtransactionLine.TransactionID = entity.ID;
        foundtransactionLine.ProductID = entity.ID;
    }



    public async Task Delete(int id)
    {
        var foundtransactionLine = _transactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
        if (foundtransactionLine is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found");

        _transactionLines.Remove(foundtransactionLine);
    }

    //Task<ProductCategory?> IEntityRepo<TransactionLine>.GetByIdAsync(int id) {
    //    throw new NotImplementedException();
    //}

    public Task CreateAsync(TransactionLine entity) {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int id, TransactionLine entity) {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id) {
        throw new NotImplementedException();
    }
}

