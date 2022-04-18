using Gas_Station.EF.Repositories;
using Gas_Station.Model;
using Gas_Station.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Gas_Station.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        

        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
            
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerEditListViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new CustomerEditListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber
            }).ToList();
        }

        [HttpGet("{id}")]
        public async Task<CustomerEditViewModel> Get(Guid id)
        {
            CustomerEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existing = await _customerRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.Name = existing.Name;
                model.Surname = existing.Surname;
                model.CardNumber = existing.CardNumber;
                
            }

           

            return model;
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _customerRepo.DeleteAsync(id);
        }



        [HttpPost]
        public async Task Post(CustomerEditViewModel customer)
        {
            var newCustomer = new Customer()
            {
  
                Name = customer.Name,
                Surname = customer.Surname,
                
            };
            if (customer.CardNumber != String.Empty)
            {
                newCustomer.CardNumber = customer.CardNumber;
            }

            await _customerRepo.CreateAsync(newCustomer);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditViewModel customer)
        {
            var customerUpdate = await _customerRepo.GetByIdAsync(customer.ID);
            if (customerUpdate == null) return NotFound();
            customerUpdate.Name = customer.Name;
            customerUpdate.Surname = customer.Surname;
            customerUpdate.CardNumber = customer.CardNumber;
            await _customerRepo.UpdateAsync(customer.ID, customerUpdate);

            return Ok();
        }
    }
}
