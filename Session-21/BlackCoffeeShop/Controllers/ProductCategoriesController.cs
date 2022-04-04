#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.Model;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeShop.Web.Models;

namespace BlackCoffeeShop.Web.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IEntityRepo<ProductCategory> _productCategoryRepo;

        public ProductCategoriesController(IEntityRepo<ProductCategory> productCategoryRepo)
        {
            _productCategoryRepo = productCategoryRepo;
        }

        // GET: ProductCategories
        public async Task<IActionResult> Index()
        {
            var productCategories = await _productCategoryRepo.GetAllAsync();
            List<ProductCategoryViewModel> ProductCategoryViewModels = new List<ProductCategoryViewModel>();
            if (productCategories is not null) {
                
                foreach (var prodCat in productCategories) {
                    ProductCategoryViewModels.Add(new ProductCategoryViewModel {
                        ID = prodCat.ID,
                        Description = prodCat.Description,
                        Code = prodCat.Code,
                        ProductType = prodCat.ProductType
                    });
                }
            }
            

            return View(ProductCategoryViewModels);
        }

        // GET: ProductCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _productCategoryRepo.GetByIdAsync(id.Value);

            var productCategoryDetailsModel = new ProductCategoryDetailsModel() {
                ID = productCategory.ID,
                Description = productCategory.Description,
                ProductType = productCategory.ProductType
            };
            if (productCategoryDetailsModel == null)
            {
                return NotFound();
            }

            return View(productCategoryDetailsModel);
        }

        // GET: ProductCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Description,ProductType,ID")] ProductCategoryCreateModel productCategoryModel)
        {
            if (ModelState.IsValid)
            {
                var newProductCategory = new ProductCategory() {
                    Code = productCategoryModel.Code,
                    Description = productCategoryModel.Description,
                    ProductType = productCategoryModel.ProductType
                };
                await _productCategoryRepo.CreateAsync(newProductCategory);

                /*  _context.Add(productCategory);
                  await _context.SaveChangesAsync();*/

                return RedirectToAction(nameof(Index));
            }
            return View(productCategoryModel);
        }

        // GET: ProductCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productCategory = await _productCategoryRepo.GetByIdAsync(id.Value);
            var prodCatEditModel = new ProductCategoryEditModel() {
                ID = productCategory.ID,
                Code = productCategory.Code,
                Description= productCategory.Description,
                ProductType = productCategory.ProductType
            };
//            var productCategory = await _context.ProductCategories.FindAsync(id);
            if (prodCatEditModel == null)
            {
                return NotFound();
            }
            return View(prodCatEditModel);
        }

        // POST: ProductCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,Description,ProductType,ID")] ProductCategory productCategory)
        {
            if (id != productCategory.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _productCategoryRepo.UpdateAsync(id, productCategory);
                    /*_context.Update(productCategory);
                    await _context.SaveChangesAsync();*/
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductCategoryExists(productCategory.ID))
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
            return View(productCategory);
        }

        // GET: ProductCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productCategory = await _productCategoryRepo.GetByIdAsync(id.Value);
            var prodCatDeleteView = new ProductCategoryDeleteModel() {
                ID = productCategory.ID,
                Code = productCategory.Code,
                Description = productCategory.Description,
                ProductType = productCategory.ProductType
            };
            /*var productCategory = await _context.ProductCategories
                .FirstOrDefaultAsync(m => m.ID == id);*/
            if (prodCatDeleteView == null)
            {
                return NotFound();
            }

            return View(prodCatDeleteView);
        }

        // POST: ProductCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productCategoryRepo.DeleteAsync(id);

         /*   var productCategory = await _context.ProductCategories.FindAsync(id);
            _context.ProductCategories.Remove(productCategory);
            await _context.SaveChangesAsync();*/
            return RedirectToAction(nameof(Index));
        }

        private bool ProductCategoryExists(int id)
        {
            return _productCategoryRepo.GetAll().Any(e => e.ID == id);
        }
    }
}
