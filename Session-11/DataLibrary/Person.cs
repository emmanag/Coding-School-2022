using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get
            {
                return $"{Name} {Surname}";
            }
        }

        public Person()
        {
            ID = Guid.NewGuid();
        }
    }
}
