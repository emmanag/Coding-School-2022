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
        private ControlsHelper _controlsHelper;
        private StorageHelper _storageHelper;
        public EngineersF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _engineerHandler = new EngineerHandler();
            _controlsHelper = new ControlsHelper();
            _storageHelper = new StorageHelper();
        }

        private void EngineersF_Load(object sender, EventArgs e)
        {
            
            PopulateCars();
            PopulateControls();
        }

        private void PopulateControls()
        {
            _controlsHelper.PopulateManagersColumns(ManagerIDlookup, bsManagerID, _carService.Managers);
            _controlsHelper.SetColumn(ManagerIDlookup, gridView1, "ManagerID");
        }

        private void PopulateCars()
        {


            bsEngineers.DataSource = _carService;
            bsEngineers.DataMember = "Engineers";

            GrdEngineers.DataSource = bsEngineers;
            _controlsHelper.HideColumns("ID", gridView1);
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
            _engineer = bsEngineers.Current as Engineer;

            EngineerF engineerF = new EngineerF(_carService, _engineer);
            engineerF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            var engineer = bsEngineers.Current as Engineer;
            _engineerHandler.Delete(engineer, _carService.Engineers);
            _storageHelper.SaveData("storage.json", _carService);
            gridView1.RefreshData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
