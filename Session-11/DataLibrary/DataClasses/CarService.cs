using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class CarService
    {
        public List<Customer> Customers { get; set; }
        public List<Car> Cars { get; set; }
        public List<ServiceTask> ServiceTasks { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Engineer> Engineers { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<MonthlyLedger> MonthlyLedgers { get; set; }

        public CarService()
        {
            Customers = new List<Customer>();
            Cars = new List<Car>();
            ServiceTasks = new List<ServiceTask>();
            Managers = new List<Manager>();
            Engineers = new List<Engineer>();
            Transactions = new List<Transaction>();
            MonthlyLedgers = new List<MonthlyLedger>();
        }
    }
}
