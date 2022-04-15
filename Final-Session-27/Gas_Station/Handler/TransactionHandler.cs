using Gas_Station.Model;
using Gas_Station.Shared.ViewModels;

namespace Handler
{
    public class TransactionHandler
    {
        
        public TransactionHandler()
        {
            
        }

        public decimal CalculateNetValue(decimal quantity, decimal price)
        {
            return quantity * price;
        }

        public decimal CalculateLineTotalValue(decimal discountValue, decimal netValue)
        {
            return netValue - discountValue;
        }

        public decimal CalculateTransactionTotalValue(List<TransactionLineEditViewModel> linesTotalValues)
        {
            return linesTotalValues.Sum(x => x.TotalValue);
        }

        public decimal ApplyTenPercentDiscount(decimal netValue)
        {
            if (netValue >= 20)
            {
                return netValue * 0.10m;
            }
            return 0;
        }

        public bool CheckFuelExist(List<TransactionLineEditViewModel> transactionLines, List<ItemListViewModel> items)
        {

            foreach (var tl in transactionLines)
            {
                var currItem = items.FirstOrDefault(i => i.ID == tl.ItemID);
                if (currItem is null) return false;
                if (currItem.ItemType == ItemType.Fuel)
                    return true;
            }
            return false;
        }

        public bool CheckCardPaymentAvail(decimal totalValue)
        {
            return totalValue <= 50;
        }
    }
}