
namespace BlackCoffeeshop.Model;
public class TransactionLine : BaseEntity {
    public int ProductID { get; set; }
    public int TransactionID { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalPrice { get; set; }
    public Transaction Transaction { get; set; }    
}
