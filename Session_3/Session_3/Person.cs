using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    public class Person
    {
        public Guid ID { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string GetName() { return Name; }
        public void SetName(string name) { Name = name; }
        public Person()

        {

        }
    }
}
