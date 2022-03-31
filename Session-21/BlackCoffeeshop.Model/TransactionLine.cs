
namespace BlackCoffeeshop.Model;
public class TransactionLine {
    public Guid ID { get; set; }
    public Guid ProductID { get; set; }
    public Guid TransactionID { get; set; }
    public int Quantity { get; set; }
    public string ProductDes { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPerCent { get; set; }
    public decimal Discount { get; set; }
    public decimal DisplayPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalCost { get; set; }

    
}
