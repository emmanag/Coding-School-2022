using Gas_Station.EF.Repositories;
using Gas_Station.Model;
using Gas_Station.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;


        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get()
        {
            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                HireDateStart = x.HireDateStart,
                HireDateEnd = x.HireDateEnd,
                SallaryPerMonth = x.SallaryPerMonth,
                EmployeeType = x.EmployeeType
            }).ToList();
        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditViewModel> Get(Guid id)
        {
            EmployeeEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existing = await _employeeRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.Name = existing.Name;
                model.Surname = existing.Surname;
                model.HireDateStart = existing.HireDateStart;
                model.HireDateEnd = existing.HireDateEnd;
                model.SallaryPerMonth = existing.SallaryPerMonth;

            }



            return model;
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _employeeRepo.DeleteAsync(id);
        }



        [HttpPost]
        public async Task Post(EmployeeEditViewModel employee)
        {
            var newEmployee = new Employee()
            {

                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SallaryPerMonth = employee.SallaryPerMonth,
                EmployeeType = employee.EmployeeType
            };

            await _employeeRepo.CreateAsync(newEmployee);
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditViewModel employee)
        {
            var itemToUpdate = await _employeeRepo.GetByIdAsync(employee.ID);
            if (itemToUpdate == null) return NotFound();


            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.SallaryPerMonth = employee.SallaryPerMonth;
            itemToUpdate.EmployeeType = employee.EmployeeType;


            await _employeeRepo.UpdateAsync(employee.ID, itemToUpdate);

            return Ok();
        }
    }
}
