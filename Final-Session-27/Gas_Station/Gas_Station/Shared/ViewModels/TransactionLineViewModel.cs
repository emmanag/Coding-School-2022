using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Shared.ViewModels
{
    public class TransactionLineViewModel
    {
        public Guid ID { get; set; }
        public string ItemDescription { get; set; }

        public decimal Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal NetValue { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal TotalValue { get; set; }
    }

    public class TransactionLineEditViewModel
    {
        public Guid ID { get; set; }
        public Guid ItemID { get; set; }

        public string ItemDescription { get; set; }

        public Guid TransactionID { get; set; }
        public decimal Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal NetValue { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal TotalValue { get; set; }
    }
}
