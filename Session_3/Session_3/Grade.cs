using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    internal class Grade
    {
        public Guid ID { get; } = Guid.NewGuid();
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Value { get; set; }

        public Grade()
        { }

        public Grade(Guid studentID)
        {
            StudentID = studentID;
        }
    }
}
