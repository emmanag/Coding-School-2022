using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;

namespace BlackCoffeeshop.EF.Configuration {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {
        public async Task Create(TransactionLine entity) {
            using var context = new ApplicationContext();
            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id) {
            using var context = new ApplicationContext();
            var foundTransLine = context.TransactionLines.SingleOrDefault(transLine => transLine.ID == id);
            if (foundTransLine is null)
                return;

            context.TransactionLines.Remove(foundTransLine);
            await context.SaveChangesAsync();
        }

        public List<TransactionLine> GetAll() {
            using var context = new ApplicationContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(int id) {
            using var context = new ApplicationContext();
            return context.TransactionLines.Where(transline => transline.ID == id).SingleOrDefault(); ;
        }

        public async Task Update(int id, TransactionLine entity) {
            using var context = new ApplicationContext();
            var foundTransLine = context.TransactionLines.SingleOrDefault(transLine => transLine.ID == id);
            if (foundTransLine is null)
                return;

            foundTransLine.ProductID = entity.ProductID;
            foundTransLine.TransactionID = entity.TransactionID;
            foundTransLine.Quantity = entity.Quantity;
            foundTransLine.ProductDes = entity.ProductDes;
            foundTransLine.Price = entity.Price;
            foundTransLine.DiscountPerCent = entity.DiscountPerCent;
            foundTransLine.Discount = entity.Discount;
            foundTransLine.DisplayPrice = entity.DisplayPrice;
            foundTransLine.TotalPrice = entity.TotalPrice;
            foundTransLine.TotalCost = entity.TotalCost;

            await context.SaveChangesAsync();
        }
    }
}
