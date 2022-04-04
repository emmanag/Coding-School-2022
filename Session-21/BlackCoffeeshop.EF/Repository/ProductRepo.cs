using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;
using Microsoft.EntityFrameworkCore;

namespace BlackCoffeeshop.EF.Configuration {
    public class ProductRepo : IEntityRepo<Product> {
        private readonly ApplicationContext context;
        public ProductRepo(ApplicationContext dbCOntext) {
            context = dbCOntext;
        }
        public async Task Create(Product entity) {
            using var context = new ApplicationContext();
            context.Products.Add(entity);
            await context.SaveChangesAsync();
        }
        #region SYNC
        public async Task Delete(int id) {
            using var context = new ApplicationContext();
            var foundTodo = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (foundTodo is null)
                return;

            context.Products.Remove(foundTodo);
            await context.SaveChangesAsync();
        }
        public List<Product> GetAll() {
            using var context = new ApplicationContext();
            return context.Products.ToList();
        }
        public Product? GetById(int id) {
            using var context = new ApplicationContext();
            return context.Products.Where(prod => prod.ID == id).SingleOrDefault();
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
        #endregion

        #region ASYNC
        public async Task CreateAsync(Product entity) {
            if (entity.ID != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Products.Add(entity);

            await context.SaveChangesAsync();
        }
        public async Task<Product?> GetByIdAsync(int id) {
            return await context.Products.SingleOrDefaultAsync(prod => prod.ID == id);
        }
        public async Task<IEnumerable<Product>> GetAllAsync() {
            return await context.Products.ToListAsync();
        }
        public async Task DeleteAsync(int id) {
            var dbProd = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Products.Remove(dbProd);

            await context.SaveChangesAsync();
        }
        public async Task UpdateAsync(int id, Product entity) {
            var dbProd = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            dbProd.Code = entity.Code;
            dbProd.Description = entity.Description;
            dbProd.Cost = entity.Cost;
            dbProd.Price = entity.Price;
            dbProd.ProductCategoryID = entity.ProductCategoryID;

            await context.SaveChangesAsync();
        }

        #endregion
    }
}
