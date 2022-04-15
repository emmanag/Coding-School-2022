using Gas_Station.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Shared.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool IsLogin { get; set; }
    }
}
