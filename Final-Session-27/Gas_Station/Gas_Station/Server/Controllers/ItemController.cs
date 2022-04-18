using Gas_Station.EF.Repositories;
using Gas_Station.Model;
using Gas_Station.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _customerRepo;


        public ItemController(IEntityRepo<Item> customerRepo)
        {
            _customerRepo = customerRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new ItemListViewModel
            {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                ItemType = x.ItemType,
                Price = x.Price,
                Cost = x.Cost
            }).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ItemEditViewModel> Get(Guid id)
        {
            ItemEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existing = await _customerRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.Code = existing.Code;
                model.Description = existing.Description;
                model.ItemType = existing.ItemType;
                model.Price = existing.Price;
                model.Cost = existing.Cost;

            }



            return model;
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _customerRepo.DeleteAsync(id);
        }



        [HttpPost]
        public async Task Post(ItemEditViewModel customer)
        {
            var newItem = new Item()
            {

                Code = customer.Code,
                Description = customer.Description,
                ItemType = customer.ItemType,
                Price= customer.Price,
                Cost= customer.Cost
            };

            await _customerRepo.CreateAsync(newItem);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel customer)
        {
            var itemToUpdate = await _customerRepo.GetByIdAsync(customer.ID);
            if (itemToUpdate == null) return NotFound();

            
            itemToUpdate.Code = customer.Code;
            itemToUpdate.Description = customer.Description;
            itemToUpdate.ItemType = customer.ItemType;
            itemToUpdate.Price = customer.Price;
            itemToUpdate.Cost = customer.Cost;


            await _customerRepo.UpdateAsync(customer.ID, itemToUpdate);

            return Ok();
        }
    }
}
