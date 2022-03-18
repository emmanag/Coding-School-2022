using DataLibrary;
using Session_11.HelperFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class EngineersF : Form
    {
        private CarService _carService;
        private Engineer _engineer;
        private EngineerHandler _engineerHandler;
        public EngineersF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _engineerHandler = new EngineerHandler();
        }

        private void EngineersF_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateCars();
        }

        private void PopulateControls()
        {

        }

        private void PopulateCars()
        {


            bsEngineers.DataSource = _carService;
            bsEngineers.DataMember = "Engineers";

            GrdEngineers.DataSource = bsEngineers;

        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            var engineers = bsEngineers.Current as Engineer;

            EngineerF engineerF = new EngineerF(_carService);
            engineerF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            var engineers = bsEngineers.Current as Engineer;

            EngineerF engineerF = new EngineerF(_carService, _engineer);
            engineerF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            //var engineer = bsEngineer.Current as Engineer;
            //_engineerHandler.Delete; (engineer, _carService.Cars)
            //SaveData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
