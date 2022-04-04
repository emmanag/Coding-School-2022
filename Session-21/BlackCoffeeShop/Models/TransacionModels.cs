using BlackCoffeeshop.Model;

namespace BlackCoffeeShop.Web.Models {
    public class TransacionModels {
    }

    public class TransactionLinesDetailsModel {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }

        // LINES
        public IEnumerable<TransactionLine>? TransactionLines { get; set; }
    }

}
