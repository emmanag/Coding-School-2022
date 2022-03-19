using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ItemHandlers
{
    public class MonthlyLedgerHandler
    {
        public MonthlyLedgerHandler()
        {

        }

        public decimal GetMonthlyIncome(int month, int year, CarService carService)
        {
            return carService.Transactions.FindAll(t => t.Date.Month == month && t.Date.Year == year).Sum(x => x.TotalPrice);
        }
    }
}
