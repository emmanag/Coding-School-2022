using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    [Serializable]
    public class Student
    {
        public string RegistrationNumber { get; set; }
        public int Courses { get; set; }

        public Student()
        {
            RegistrationNumber = String.Empty;
            Courses = 0;
        }

        public Student ShallowCopy()
        {
            return (Student)MemberwiseClone();
        }
    }
    public class Manager
    {

    }

    public class PetManager : Manager
    {

        public List<Student> Student { get; set; }

        public PetManager()
        {
            Student = new List<Student>();
        }


        public Student AddStudent()
        {

            return AddStudent("{enter registrationNumber}", 0);
        }

        public Student AddStudent(string registrationNumber)
        {

            return AddStudent(registrationNumber, 0);
        }

        public Student AddStudent(string registrationNumber, int courses)
        {

            Student student = new Student()
            {
                RegistrationNumber = registrationNumber,
                Courses = courses,
            };

            Student.Add(student);

            return student;
        }

    }

    



   

}
