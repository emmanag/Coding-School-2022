using BlackCoffeeshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.EF.Repository {
    public class MockProductCategory : IEntityRepo<ProductCategory> {
        private int _latestID = 1;
        private readonly List<ProductCategory> _productcategories;
        public MockProductCategory() {
            _productcategories = new List<ProductCategory>

            {
                new ProductCategory()
                {
                    ID = 1,
                    Description = "RetailProductCategory",
                    Code = "01",
                    ProductType = ProductType.Coffee
                }
            };
        }

        public Task Create(ProductCategory entity) {
            throw new NotImplementedException();
        }
        public Task Delete(int id) {
            throw new NotImplementedException();
        }
        public List<ProductCategory> GetAll() {
            throw new NotImplementedException();
        }
        public ProductCategory? GetById(int id) {
            throw new NotImplementedException();
        }
        public Task Update(int id, ProductCategory entity) {
            throw new NotImplementedException();
        }

        //ASYNC
        public Task CreateAsync(ProductCategory entity) {
            entity.ID = ++_latestID;
            _productcategories.Add(entity);

            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id) {
            var foundProdCat = _productcategories.SingleOrDefault(prodCat => prodCat.ID == id);
            if (foundProdCat is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            _productcategories.Remove(foundProdCat);

            return Task.CompletedTask;
        }

        public Task<IEnumerable<ProductCategory>> GetAllAsync() {
            return Task.FromResult(_productcategories.AsEnumerable());
        }
        public Task<ProductCategory?> GetByIdAsync(int id) {
            return Task.FromResult(_productcategories.SingleOrDefault(product => product.ID == id));
        }
        public Task UpdateAsync(int id, ProductCategory entity) {
            var foundProdCat = _productcategories.SingleOrDefault(todo => todo.ID == id);
            if (foundProdCat is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            foundProdCat.Code = entity.Code;
            foundProdCat.ProductType = entity.ProductType;
            foundProdCat.Description = entity.Description;

            return Task.CompletedTask;
        }

    }
}

