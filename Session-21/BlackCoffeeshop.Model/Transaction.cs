
namespace BlackCoffeeshop.Model;
public class Transaction : BaseEntity {
    public DateTime Date { get; set; }
    public Guid EmployeeID { get; set; }
    public Guid CustomerID { get; set; }
    public List<TransactionLine> TransactionLines { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalCost { get; set; }
    public string EmployeeName { get; set; }
    

}
