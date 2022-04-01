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

namespace BlackCoffeeShop.Web.Controllers
{
    public class CustomersController : Controller
    {
        
        private readonly IEntityRepo<Customer> _customerRepo; 


        public CustomersController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }
        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View( _customerRepo.GetAll());
        }
        

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerRepo.GetById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Description,ID")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var newCustomer = new Customer() { Code = customer.Code,
                Description = customer.Description
                };
                _customerRepo.Create(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerRepo.GetById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,Description,ID")] Customer customer)
        {
            if (id != customer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _customerRepo.Update(id,customer);
                    //await _customerRepo.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (_customerRepo.GetById(id) is null)
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerRepo.GetById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = _customerRepo.GetById(id);
            _customerRepo.Delete(id);
           //await _customersRepo.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //private bool CustomerExists(int id)
        //{
        //    return _customerRepo.GetAll(e => e.ID == id));
        //}
    }
}
