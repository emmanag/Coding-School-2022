using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    [Serializable]
    public class Customer : Person
    {
        public string Phone { get; set; }
        public string TIN { get; set; }

        public Customer()
        {

        }
    }
}
