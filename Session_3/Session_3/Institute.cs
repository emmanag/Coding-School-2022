using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    internal class Institute
    {

        Guid ID = Guid.NewGuid();
        public string Name;
        public int YearsInService { get; set; }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name) { Name = name; }

        public Institute()
        {

        }

    }
}
