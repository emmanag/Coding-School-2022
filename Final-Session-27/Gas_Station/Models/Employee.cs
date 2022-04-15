using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gas_Station.Model
{
    public class Employee : BaseEntity
    {
        
        public string Name { get; set; }
        public string Surname  { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public List<Transaction> Transaction { get; set; }

        public Employee () { }
    }



   
}
