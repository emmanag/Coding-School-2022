
namespace BlackCoffeeshop.Model;
public class TransactionLine : BaseEntity {
    public int ProductID { get; set; }
    public int TransactionID { get; set; }
    public int Quantity { get; set; }
    public string ProductDes { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPerCent { get; set; }
    public decimal Discount { get; set; }
    public decimal DisplayPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalCost { get; set; }
    public Transaction Transaction { get; set; }

    
}
