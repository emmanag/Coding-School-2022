using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_14.model
{
    
    public class Car : Item
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarRegNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{Brand} {Model}";
            }
        }
    }
}