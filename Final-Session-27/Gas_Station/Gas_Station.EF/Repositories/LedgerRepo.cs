using Gas_Station.EF.Context;
using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;
using Gas_Station.EF.Repositories;

namespace Gas_Station.EF.Repositories
{
    public class LedgerRepo : IEntityRepo<Ledger>
    {
        private readonly GasStationContext context;
        public LedgerRepo(GasStationContext dbCOntext)
        {
            context = dbCOntext;
        }
        public async Task CreateAsync(Ledger entity)
        {
            if (entity.ID != Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Ledgers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundLedger = context.Ledgers.SingleOrDefault(ledger => ledger.ID == id);
            if (foundLedger is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            context.Ledgers.Remove(foundLedger);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ledger>> GetAllAsync()
        {
            return await context.Ledgers.ToListAsync();
        }

        public async Task<Ledger?> GetByIdAsync(Guid id)
        {
            return await context.Ledgers.SingleOrDefaultAsync(ledger => ledger.ID == id);
        }

        public async Task UpdateAsync(Guid id, Ledger entity)
        {
            var foundLedger = context.Ledgers.SingleOrDefault(ledger => ledger.ID == id);
            if (foundLedger is null)
                return;

            foundLedger.Year = entity.Year;
            foundLedger.Month = entity.Month;
            foundLedger.Income = entity.Income;
            foundLedger.Expenses = entity.Expenses;
            foundLedger.Total = entity.Total;

            await context.SaveChangesAsync();
        }
    }
}
