using Gas_Station.EF.Context;
using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Gas_Station.EF.Repositories;

namespace Gas_Station.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        private readonly GasStationContext context;
        public TransactionLineRepo(GasStationContext dbCOntext)
        {
            context = dbCOntext;
        }
        public async Task CreateAsync(TransactionLine entity)
        {
            if (entity.ID != Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransactionLine is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            context.TransactionLines.Remove(foundTransactionLine);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransactionLine>> GetAllAsync()
        {
            return await context.TransactionLines.ToListAsync();
        }

        public async Task<TransactionLine?> GetByIdAsync(Guid id)
        {
            return await context.TransactionLines.SingleOrDefaultAsync(transactionLine => transactionLine.ID == id);
        }

        public async Task UpdateAsync(Guid id, TransactionLine entity)
        {
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
            if (foundTransactionLine is null)
                return;

            foundTransactionLine.TransactionID = entity.TransactionID;
            foundTransactionLine.ItemID = entity.ItemID;
            foundTransactionLine.Quantity = entity.Quantity;
            foundTransactionLine.ItemPrice = entity.ItemPrice;
            foundTransactionLine.NetValue = entity.NetValue;
            foundTransactionLine.DiscountPercent = entity.DiscountPercent;
            foundTransactionLine.DiscountValue = entity.DiscountValue;
            foundTransactionLine.TotalValue = entity.TotalValue;

            await context.SaveChangesAsync();
        }
    }
}
