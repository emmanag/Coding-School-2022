using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Shared.ViewModels
{
    public class CustomerEditListViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; } = string.Empty;
    }

    public class CustomerEditViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; } = string.Empty;
    }
    
}
