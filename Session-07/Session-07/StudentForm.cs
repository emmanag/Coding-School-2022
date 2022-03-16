using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc;
using Newtonsoft.Json;



namespace Session_07
{
    public partial class StudentForm : Form
    {
        public List<StudentForm> Students { get; set; }

        private StudentForm _selectedStudent;
        private StudentForm _originalStudent;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //UpdateStudent();

            //ShowList();
        }
    }
}
