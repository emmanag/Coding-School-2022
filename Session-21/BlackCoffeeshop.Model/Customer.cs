using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.Model;

public class Customer : BaseEntity {
    public string Code { get; set; }
    public string Description { get; set; } = string.Empty;
    public Transaction Transaction { get; set; }

}
