using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_14.model
{
    public class ServiceTask : Item
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }

        public ServiceTask()
        {

        }
    }
}
