﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackCoffeeshop.Model;

namespace BlackCoffeeshop.EF.Repository
{
    public class MockProduct : IEntityRepo<Product>
    {
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

        public Task CreateAsync(Product entity) {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            _products.Remove(GetById(id));
        }

        public Task DeleteAsync(int id) {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Task<IEnumerable<Product>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Product? GetById(int id)
        {
            return _products.SingleOrDefault(product => product.ID == id);
        }

        public Task<ProductCategory?> GetByIdAsync(int id) {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Product entity)
        {
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

        public Task UpdateAsync(int id, Product entity) {
            throw new NotImplementedException();
        }
    }
}