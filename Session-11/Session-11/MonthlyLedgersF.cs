using System;
using DataLibrary;
using Session_11.HelperFunctions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class MonthlyLedgersF : Form
    {
        private CarService _carService;
        private MonthlyLedger _monthlyLenger;

        public MonthlyLedgersF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _monthlyLenger = new MonthlyLedger();
        }

        private void MonthlyLedgersF_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateMonthlyLedgers();
        }

        private void PopulateControls()
        {

        }

        private void PopulateMonthlyLedgers()
        {
            //bsMonthlyLedger.DataSource = _carService;
            //bsMonthlyLedger.DataMember = "MonthlyLedgers";

            //GrdMonthlyLedgers.DataSource = bsMonthlyLedger;

        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            // TODO isos den xreiazete new

        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
           //TODO isos oute edit bgainei gt only read;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            //TODO Delete an current object form the grid
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
