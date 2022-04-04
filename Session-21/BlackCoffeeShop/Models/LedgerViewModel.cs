namespace BlackCoffeeShop.Web.Models {
    public class LedgerViewModel {
        private decimal _stockCost;
        private decimal _rentCost;
        private decimal _fixedExpenses;
        LedgerViewModel() {
            _stockCost = 0;
            _rentCost = 3000;
            _fixedExpenses = _rentCost;
        }
       
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses => _fixedExpenses + _stockCost;
        public decimal Total => Income - Expenses;
    }
}
/*Year, Month, Income, Expenses, Total*/