using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    [Serializable]
    public class Engineer : Person
    {
        public Guid? ManagerID { get; set; }
        public decimal SallaryPerMonth { get; set; }

        public StatusEnum Status { get; set; }

        public Engineer()
        {
        }

    }
}
