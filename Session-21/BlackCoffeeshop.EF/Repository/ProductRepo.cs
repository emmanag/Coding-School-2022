using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;

namespace BlackCoffeeshop.EF.Configuration {
    public class ProductRepo : IEntityRepo<Product> {
        public async Task Create(Product entity) {
            using var context = new ApplicationContext();
            context.Products.Add(entity);
            await context.SaveChangesAsync();
        }

        public Task CreateAsync(Product entity) {
            throw new NotImplementedException();
        }

        public async Task Delete(int id) {
            using var context = new ApplicationContext();
            var foundTodo = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (foundTodo is null)
                return;

            context.Products.Remove(foundTodo);
            await context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id) {
            throw new NotImplementedException();
        }

        public List<Product> GetAll() {
            using var context = new ApplicationContext();
            return context.Products.ToList();
        }

        public Task<IEnumerable<Product>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Product? GetById(int id) {
            using var context = new ApplicationContext();
            return context.Products.Where(prod => prod.ID == id).SingleOrDefault();
        }

        public Task<ProductCategory?> GetByIdAsync(int id) {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Product entity) {
            using var context = new ApplicationContext();
            var foundProduct = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (foundProduct is null)
                return;

            foundProduct.Code = entity.Code;
            foundProduct.Description = entity.Description;
            foundProduct.Cost = entity.Cost;
            foundProduct.Price = entity.Price;
            foundProduct.ProductCategoryID = entity.ProductCategoryID;

            await context.SaveChangesAsync();
        }

        public Task UpdateAsync(int id, Product entity) {
            throw new NotImplementedException();
        }

        Task<Product?> IEntityRepo<Product>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
