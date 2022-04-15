using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Model
{
    public class Customer  : BaseEntity
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
        public List<Transaction> Transaction { get; set; }

        public Customer()
        {
            
        }

    }
}