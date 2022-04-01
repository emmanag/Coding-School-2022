using BlackCoffeeshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.EF.Repository
{
    public class MockProductCategory : IEntityRepo<ProductCategory>
    {
        private readonly List<ProductCategory> _productcategories;
        public MockProductCategory()
        {
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
        public async Task Create(ProductCategory entity)
        {
            _productcategories.Add(entity);
        }

        public async Task Delete(int id)
        {
            _productcategories.Remove(GetById(id));
        }

        public List<ProductCategory> GetAll()
        {
            return _productcategories;
        }

        public ProductCategory? GetById(int id)
        {
            return _productcategories.SingleOrDefault(product => product.ID == id);
        }

        public async Task Update(int id, ProductCategory entity)
        {
            var foundProductCategory = _productcategories.SingleOrDefault(product => product.ID == id);

            if (foundProductCategory is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            foundProductCategory.Code = entity.Code;
            foundProductCategory.ProductType = entity.ProductType;
            foundProductCategory.Description = entity.Description;
            //foundProductCategory.ID = entity.ID;
        }


    }
}

