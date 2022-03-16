using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    internal class ServiceTask
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double Hours { get; set; }

        public ServiceTask()
        {

        }
    }
}
