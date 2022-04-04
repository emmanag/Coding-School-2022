﻿#nullable disable
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
    public class TransactionsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLinesRepo;
        public TransactionsController(IEntityRepo<Transaction> dbContextTrans, IEntityRepo<TransactionLine> dbContextLine)
        {
            _transactionRepo = dbContextTrans;
            _transactionLinesRepo = dbContextLine;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.Transactions.Include(t => t.Customer).Include(t => t.Employee);
            return View(await applicationContext.ToListAsync());
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var transaction = await _transactionRepo.GetByIdAsync(id.Value);
            
            if (transaction == null)
            {
                return NotFound();
            }
            var transactionLines = await _transactionLinesRepo.GetAllAsync();
            
            var transactionLineEditModel = new TransactionLinesDetailsModel() {
                Date=transaction.Date,
                TransactionID = transaction.ID,
                TransactionLines= transactionLines.Where(x=> x.TransactionID == transaction.ID)
            };

            return View(transactionLineEditModel);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["ID"] = new SelectList(_context.Customers, "ID", "Code");
            ViewData["ID"] = new SelectList(_context.Employees, "ID", "Name");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,EmployeeID,CustomerID,PaymentMethod,TotalPrice,TotalCost,EmployeeName,ID")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ID"] = new SelectList(_context.Customers, "ID", "Code", transaction.ID);
            ViewData["ID"] = new SelectList(_context.Employees, "ID", "Name", transaction.ID);
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            ViewData["ID"] = new SelectList(_context.Customers, "ID", "Code", transaction.ID);
            ViewData["ID"] = new SelectList(_context.Employees, "ID", "Name", transaction.ID);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,EmployeeID,CustomerID,PaymentMethod,TotalPrice,TotalCost,EmployeeName,ID")] Transaction transaction)
        {
            if (id != transaction.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.ID))
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
            ViewData["ID"] = new SelectList(_context.Customers, "ID", "Code", transaction.ID);
            ViewData["ID"] = new SelectList(_context.Employees, "ID", "Name", transaction.ID);
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .Include(t => t.Customer)
                .Include(t => t.Employee)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return _context.Transactions.Any(e => e.ID == id);
        }
    }
}
