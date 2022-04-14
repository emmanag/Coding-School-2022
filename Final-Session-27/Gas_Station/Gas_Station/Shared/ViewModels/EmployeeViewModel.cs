using Gas_Station.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Shared.ViewModels
{
    public class EmployeeListViewModel
    {
       
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime HireDateStart { get; set; } = DateTime.Now;
            public DateTime HireDateEnd { get; set; } = DateTime.Now;
        public decimal SallaryPerMonth { get; set; }
            public EmployeeType EmployeeType { get; set; }


    }

    public class EmployeeEditViewModel
    {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; } = DateTime.Now;
        public DateTime HireDateEnd { get; set; } = DateTime.Now;
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }


    }

    //public class EmployeeListViewModel
    //{
    //    public List<EmployeeViewModel> EmployeeList { get; set; } = new List<EmployeeViewModel>();

    //}
}
