using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_14.model
{
    public class Manager : Person
    {
        public decimal SallaryPerMonth { get; set; }
        public List<Engineer> Engineers { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Manager()
        {

        }
    }
}
