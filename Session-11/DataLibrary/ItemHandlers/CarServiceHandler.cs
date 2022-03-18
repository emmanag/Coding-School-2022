using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLibrary.ItemHandlers
{
    public class CarServiceHandler
    {
        public CarServiceHandler()
        {

        }

        public int GetMaxDayWorkload(CarService carService)
        {
            return carService.Engineers.Count() * 8;
        }

        public decimal GetReservedHours(CarService carService)
        {
            //test commit
            decimal hours = 0m;
            foreach (var item in carService.Transactions.FindAll(x => x.Date.Day == DateTime.Now.Day))
            {
                hours += item.TransactionLines.Sum(t => t.Hours);
            }

            return hours;
        }
    }
}
