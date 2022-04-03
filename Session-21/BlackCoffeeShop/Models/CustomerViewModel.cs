namespace BlackCoffeeShop.Web.Models
{
    public class CustomerViewModel
    {
        public int ID { get; set; } 
        public string Code { get; set; }
        public string Description { get; set; }

    }
    public class CustomerUpdateViewModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
