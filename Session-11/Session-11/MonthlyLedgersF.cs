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
        private ControlsHelper _controlsHelper;

        public MonthlyLedgersF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _monthlyLenger = new MonthlyLedger();
            _controlsHelper = new ControlsHelper();
        }

        private void MonthlyLedgersF_Load(object sender, EventArgs e)
        {
            bsLedgers.DataSource = _carService.MonthlyLedgers;
            GrdMonthlyLedgers.DataSource = bsLedgers;
            _controlsHelper.HideColumns("DateTimeValue", grvMothlyLedger);
        }
    }
}
