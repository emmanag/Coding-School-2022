using Gas_Station.EF.Context;
using Gas_Station.Model;
using Microsoft.EntityFrameworkCore;

namespace Gas_Station.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly GasStationContext context;
        public ItemRepo(GasStationContext dbCOntext)
        {
            context = dbCOntext;
        }
        public async Task CreateAsync(Item entity)
        {
            if (entity.ID != Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Items.Add(entity);
            await context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            var foundItem = context.Items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                return;

            context.Items.Remove(foundItem);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var foundItem = context.Items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            context.Items.Remove(foundItem);
            await context.SaveChangesAsync();
        }

        public List<Item> GetAll()
        {

            return context.Items.ToList();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return context.Items.Where(item => item.ID == id).SingleOrDefault();
        }
        public async Task Update(Guid id, Item entity)
        {
            using var context = new GasStationContext();
            var foundItem = context.Items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                return;

            foundItem.Code = entity.Code;
            foundItem.Description = entity.Description;
            foundItem.ItemType = entity.ItemType;
            foundItem.Price = entity.Price;
            foundItem.Cost = entity.Cost;

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id, Item entity)
        {
            var foundItem = context.Items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                return;

            foundItem.Code = entity.Code;
            foundItem.Description = entity.Description;
            foundItem.ItemType = entity.ItemType;
            foundItem.Price = entity.Price;
            foundItem.Cost = entity.Cost;

            await context.SaveChangesAsync();
        }
    }
}
