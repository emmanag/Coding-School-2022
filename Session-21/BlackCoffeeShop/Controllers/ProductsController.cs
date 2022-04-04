#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.Model;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeShop.Web.Models;

namespace BlackCoffeeShop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IEntityRepo<Product> _productRepo;
        private readonly IEntityRepo<ProductCategory> _productCategoryRepo;


        public ProductsController(IEntityRepo<Product> productRepo, IEntityRepo<ProductCategory> productCategoryRepo)
        {
            _productRepo = productRepo;
            _productCategoryRepo = productCategoryRepo;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var products = await _productRepo.GetAllAsync();
            return View(products);
        }

        // GET: Products/Create
        public async Task<IActionResult> CreateAsync()
        {
            var productCategories =  await _productCategoryRepo.GetAllAsync();
            var productsCreateModel = new ProductsCreateModel() {
                ProductCategories = productCategories
            };


            return View(productsCreateModel);
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductCode,ProductDescription,ProductProductCategoryID,ProductPrice,ProductCost")] ProductsCreateModel productsCreateModel)
        {
            if (ModelState.IsValid)
            {
                await _productRepo.CreateAsync(new Product() {
                    Code = productsCreateModel.ProductCode,
                    Description = productsCreateModel.ProductDescription,
                    Cost = productsCreateModel.ProductCost,
                    Price = productsCreateModel.ProductPrice,
                    ProductCategoryID = productsCreateModel.ProductProductCategoryID,
                    ProductCategory = await _productCategoryRepo.GetByIdAsync(productsCreateModel.ProductProductCategoryID) 
                });

                return RedirectToAction(nameof(Index));
            }
            return View(productsCreateModel);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productRepo.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            var productCategories = await _productCategoryRepo.GetAllAsync();

            var productEditModel = new ProductEditModel() {
                ProductID = product.ID,
                ProductCode = product.Code,
                ProductCost = product.Cost,
                ProductPrice = product.Price,
                ProductProductCategoryID = product.ProductCategoryID,
                ProductDescription = product.Description,
                
                ProductCategories = productCategories
            };
            
            return View(productEditModel);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductCode,ProductDescription,ProductProductCategoryID,ProductPrice,ProductCost,ProductID")] ProductEditModel productsEditModel)
        {
            if (id != productsEditModel.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   await _productRepo.Update(id, new Product() {
                        Code = productsEditModel.ProductCode,
                        Cost = productsEditModel.ProductCost,
                        Price = productsEditModel.ProductPrice,
                        ProductCategoryID = productsEditModel.ProductProductCategoryID,
                        Description = productsEditModel.ProductDescription,
                    });

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(productsEditModel.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(productsEditModel);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productRepo.GetByIdAsync(id.Value);

            if (product == null)
            {
                return NotFound();
            }
            var productDeleteModel = new ProductDeleteModel() {
                ProductID = product.ID,
                ProductCode = product.Code,
                ProductCost = product.Cost,
                ProductPrice = product.Price,
                ProductProductCategoryID = product.ProductCategoryID,
                ProductDescription = product.Description
            };

            return View(productDeleteModel);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productRepo.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
