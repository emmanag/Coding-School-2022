using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Session_07
{
    public partial class Form1 : Form
    {
        private const string FILE_NAME = "storage.json";

        //private Calc. _petShop;
        public Form1()
        {
            InitializeComponent();
        }

        private void Loadprofessor(object sender, EventArgs e)
        {

            ProfessorForm professorForm = new ProfessorForm();



            professorForm.ShowDialog();
        }

        private void Saveprofessor(object sender, EventArgs e)
        {

        }

        private void Loaduniversity(object sender, EventArgs e)
        {
            UniversityForm universityForm = new UniversityForm();



            universityForm.ShowDialog();
        }

        private void Saveuniversity(object sender, EventArgs e)
        {

        }

        private void Loadgrade(object sender, EventArgs e)
        {
            GradeForm gradeForm = new GradeForm();



            gradeForm.ShowDialog();
        }

        private void Savegrade(object sender, EventArgs e)
        {

        }

        private void Loadcourse(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();



            courseForm.ShowDialog();
        }

        private void Savecourse(object sender, EventArgs e)
        {

        }

        private void Loadschedule(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();



            scheduleForm.ShowDialog();
        }

        private void Saveschedule(object sender, EventArgs e)
        {

        }

        private void Editprofessor(object sender, EventArgs e)
        {

        }

        private void Editstudent(object sender, EventArgs e)
        {
        }
        //{
        //    if (_petShop != null && _petShop.Pets.Count() > 0)
        //    {

        //        // open form
        //        PetForm petForm = new PetForm();

        //        // set pets array
        //        petForm.Pets = _petShop.Pets;

        //        // show pet form
        //        petForm.ShowDialog();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Petshop is not loaded!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //    }
        //}

        private void Edituniversity(object sender, EventArgs e)
        {

        }

        private void Editgrade(object sender, EventArgs e)
        {

        }

        private void Editcourse(object sender, EventArgs e)
        {

        }

        private void Editschedule(object sender, EventArgs e)
        {

        }

        private void Loadstudent(object sender, EventArgs e)
        {
            

                StudentForm studentForm = new StudentForm();
                                     


                studentForm.ShowDialog();

            //petForm.Pets = _petShop.Pets;


        }
    }
}
