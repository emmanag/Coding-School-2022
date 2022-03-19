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

        public decimal GetMonthlyIncome(DateTime dateTime, CarService carService)
        {
            return carService.Transactions.FindAll(t => t.Date.Month == dateTime.Month && t.Date.Year == dateTime.Year).Sum(x => x.TotalPrice);
        }

        public decimal GetTotal(DateTime dateTime, CarService carService)
        {
            return GetMonthlyIncome(dateTime, carService); //- GetMonthlyExpenses(carService);
        }

        public decimal GetMonthlyExpenses(CarService carService)
        {
            decimal managersSalaries = carService.Managers.Sum(m => m.SallaryPerMonth);
            decimal engineersSalaries = carService.Engineers.Sum(m => m.SallaryPerMonth);
            
            return managersSalaries + engineersSalaries;
        }
    }
}
