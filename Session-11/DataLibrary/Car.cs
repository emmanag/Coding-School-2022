using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Car : Item
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int CarRegNumber { get; set; }

        public Car()
        {

        }
    }
}
