
namespace BlackCoffeeshop.Model;

public class ProductCategory {
    public Guid ID { get; } = Guid.NewGuid();
    public string Code { get; set; }
    public string Description { get; set; }
    public ProductType ProductType { get; set; }
    public ProductCategory() {

    }
   
}
