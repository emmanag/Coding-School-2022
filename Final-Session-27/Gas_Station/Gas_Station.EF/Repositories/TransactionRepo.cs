using Gas_Station.EF.Context;
using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Gas_Station.EF.Repositories;

namespace Gas_Station.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly GasStationContext context;
        public TransactionRepo(GasStationContext dbCOntext)
        {
            context = dbCOntext;
        }
        public async Task CreateAsync(Transaction entity)
        {
            if (entity.ID == Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            context.Transactions.Remove(foundTransaction);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await context.Transactions.Include(trasaction => trasaction.Customer)
                                                    .Include(trasaction => trasaction.Employee)
                                                    .Include(trasaction => trasaction.TransactionLine)
                                                    .ThenInclude(transactionLine => transactionLine.Item)
                                                    .ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await context.Transactions.Include(trasaction => trasaction.Customer)
                                                    .Include(trasaction => trasaction.Employee)
                                                    .Include(trasaction => trasaction.TransactionLine)
                                                    .ThenInclude(transactionLine => transactionLine.Item)
                                                    .SingleOrDefaultAsync(trasaction => trasaction.ID == id);
        }

        public async Task UpdateAsync(Guid id, Transaction entity)
        {
            var foundTransaction = context.Transactions.Include(x => x.TransactionLine).SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;

            foundTransaction.Date = entity.Date;
            foundTransaction.EmployeeID = entity.EmployeeID;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.TotalValue = entity.TotalValue;

            await context.SaveChangesAsync();
        }
    }
}
