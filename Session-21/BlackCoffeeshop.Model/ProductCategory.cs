
namespace BlackCoffeeshop.Model;

public class ProductCategory : BaseEntity {
    public string Code { get; set; }
    public string Description { get; set; }
    public ProductType ProductType { get; set; }
    public Transaction Transaction { get; set; }

    public ProductCategory() {

    }
   
}
