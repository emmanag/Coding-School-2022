using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    internal class Course
    {
        public Guid ID { get; } = Guid.NewGuid();

        public string Code { get; set; }
        public string Subject { get; set; }

        public Course()
        {

        }


    }
}
