namespace BlackCoffeeshop.Model;

public class Product : BaseEntity {
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid ProductCategoryID { get; set; }
    public decimal Price { get; set; }
    public decimal Cost { get; set; }

    public Product() {

    }

    
}
