using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    internal class Professor : Person
    {

        public string Rank { get; set; }

        public Course[] Courses { get; set; }
        public void Teach(Course course, DateTime dateTime) { }
        public void SetGrade(Guid studentId, Guid courseId, int grade) { }
        public string GetName()
        {
            return "Dr " + Name;
        }

        public Professor()
        {

        }



    }
}


