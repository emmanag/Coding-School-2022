using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Shared.ViewModels
{
    public class EmployeeViewModel
    {
       
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string CardNumber { get; set; }
            
        
    }

    public class EmployeeEditViewModel
    {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }


    }

    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> EmployeeList { get; set; } = new List<EmployeeViewModel>();

    }
}
