using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.Model;

public class Customer {
    public Guid ID { get; } = Guid.NewGuid();
    public string Code { get; set; }
    public string Description { get; set; } = string.Empty;

    

   


}
