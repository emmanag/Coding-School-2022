using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackCoffeeshop.Model;

namespace BlackCoffeeshop.EF.Repository
{
    public class MockProduct : IEntityRepo<Product>
    {
        private int _latestID = 1;
        private readonly List<Product> _products;
        public MockProduct()
        {
            _products = new List<Product>

            {
                new Product()
                {
                    ID = 1,
                    Description = "RetailProduct",
                    Code = "01",
                    Cost = 12,
                    Price = 9,
                    ProductCategoryID = 1

                }
            }; 
        }
        public async Task Create(Product entity)
        {
            _products.Add(entity);
        }
        public async Task Delete(int id)
        {
            _products.Remove(GetById(id));
        }
        public List<Product> GetAll()
        {
            return _products;
        }
        public Product? GetById(int id)
        {
            return _products.SingleOrDefault(product => product.ID == id);
        }
        public async Task Update(int id, Product entity) {
            var foundProduct = _products.SingleOrDefault(product => product.ID == id);

            if (foundProduct is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            foundProduct.Code = entity.Code;
            foundProduct.Price = entity.Price;
            foundProduct.Cost = entity.Cost;
            foundProduct.ProductCategoryID = entity.ProductCategoryID;
            foundProduct.Description = entity.Description;
            //foundProduct.ID = entity.ID;
        }
        //ASYNC

        public Task CreateAsync(Product entity) {
            entity.ID = ++_latestID;
            _products.Add(entity);

            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id) {
            var foundProd = _products.SingleOrDefault(prod => prod.ID == id);
            if (foundProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            _products.Remove(foundProd);

            return Task.CompletedTask;
        }
        public Task<IEnumerable<Product>> GetAllAsync() {
            return Task.FromResult(_products.AsEnumerable());
        }
        Task<Product?> IEntityRepo<Product>.GetByIdAsync(int id) {
            return Task.FromResult(_products.SingleOrDefault(product => product.ID == id));
        }
        public Task UpdateAsync(int id, Product entity) {
            var foundProd = _products.SingleOrDefault(todo => todo.ID == id);
            if (foundProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            foundProd.ProductCategoryID = entity.ProductCategoryID;
            foundProd.Code = entity.Code;
            foundProd.Description = entity.Description;
            foundProd.Price = entity.Price;
            foundProd.Cost = entity.Cost;


            return Task.CompletedTask;
        }

    }
}
