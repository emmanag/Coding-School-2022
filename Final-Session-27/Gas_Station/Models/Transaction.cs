using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Model
{
    public class Transaction : BaseEntity
    {
        
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

        

    }
}
