using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    internal class Student : Person
    {


        public int RegistrationNumber { get; set; }

        public Course[] Course { get; set; }

        public Student()
        {

        }

        public void Attend(Course course, DateTime dateTime) { }

        public void WriteExam(Course course, DateTime dateTime) { }

    }
}
