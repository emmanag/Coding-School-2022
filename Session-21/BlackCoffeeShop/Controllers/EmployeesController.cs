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
    public class EmployeesController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeesController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeRepo.GetAllAsync();
            List<EmployeeViewModel> EmployeeViewModels = new List<EmployeeViewModel>();
            if (employees is not null)
            {

                foreach (var employee in employees)
                {
                    EmployeeViewModels.Add(new EmployeeViewModel
                    {
                        ID = employee.ID,
                        Name = employee.Name,
                        Surname = employee.Surname,
                        EmployeeType = employee.EmployeeType,
                        SalaryPerMonth = employee.SalaryPerMonth
                    });
                }
            }


            return View(EmployeeViewModels);
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _employeeRepo.GetByIdAsync(id.Value);

            var employeeDetailsModel = new EmployeeDetailsModel()
            {
                ID = employee.ID,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                SalaryPerMonth = employee.SalaryPerMonth
            };
            if (employeeDetailsModel == null)
            {
                return NotFound();
            }

            return View(employeeDetailsModel);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Surname,Name,SalaryPerMonth,ID")] EmployeeCreateModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                var newEmployee = new Employee()
                {
                    ID = employeeModel.ID,
                    Name = employeeModel.Name,
                    Surname = employeeModel.Surname,
                    EmployeeType = employeeModel.EmployeeType,
                    SalaryPerMonth = employeeModel.SalaryPerMonth
                };
                await _employeeRepo.CreateAsync(newEmployee);

                /*  _context.Add(employee);
                  await _context.SaveChangesAsync();*/

                return RedirectToAction(nameof(Index));
            }
            return View(employeeModel);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _employeeRepo.GetByIdAsync(id.Value);
            var employeeEditModel = new EmployeeEditModel()
            {
                ID = employee.ID,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                SalaryPerMonth = employee.SalaryPerMonth
            };
            //            var employee = await _context.Employee.FindAsync(id);
            if (employeeEditModel == null)
            {
                return NotFound();
            }
            return View(employeeEditModel);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Surname,Name,SalaryPerMonth,ID")] EmployeeEditModel employee)
        {
            if (id != employee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeRepo.UpdateAsync(id, new Employee()
                    {
                        EmployeeType = employee.EmployeeType,
                        ID = employee.ID,
                        Name= employee.Name,
                        Surname = employee.Surname,
                        SalaryPerMonth = employee.SalaryPerMonth
                        

                    });
                    /*_context.Update(employee);
                    await _context.SaveChangesAsync();*/
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.ID))
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
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _employeeRepo.GetByIdAsync(id.Value);
            var employeeDeleteView = new EmployeeDeleteModel()
            {
                ID = employee.ID,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                SalaryPerMonth = employee.SalaryPerMonth
            };
            /*var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.ID == id);*/
            if (employeeDeleteView == null)
            {
                return NotFound();
            }

            return View(employeeDeleteView);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _employeeRepo.DeleteAsync(id);

            /*   var employee = await _context.Employee.FindAsync(id);
               _context.Employee.Remove(employee);
               await _context.SaveChangesAsync();*/
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _employeeRepo.GetAll().Any(employee => employee.ID == id);
        }
    }
}
