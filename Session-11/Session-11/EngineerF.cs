using DataLibrary;
using Session_11.HelperFunctions;
using System;
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
    public partial class EngineerF : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private Engineer _engineer;
        private EngineerHandler _engineerHandler;
        private StorageHelper _storageHelper;

        public EngineerF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _engineerHandler = new EngineerHandler();
            _storageHelper = new StorageHelper();
        }

        public EngineerF(CarService carService, Engineer engineer) : this(carService)
        {
            _engineer = engineer;
        }

        private void SetDataBindings()
        {
            Ctrlname.DataBindings.Add(new Binding("EditValue", bsEngineer, "Name", true));
            Ctrlsurname.DataBindings.Add(new Binding("EditValue", bsEngineer, "Surname", true));
            Ctrlsallarypermonth.DataBindings.Add(new Binding("EditValue", bsEngineer, "SallaryPerMonth", true));
            CtrlmanagerID.DataBindings.Add(new Binding("EditValue", bsEngineer, "ManagerID", true));
            
        }
        private void PopulateControls()
        {
            var controlHelper = new ControlsHelper();
            controlHelper.PopulateManagers(CtrlmanagerID.Properties, _carService.Managers);
        }

        private void SaveEngineer()
        {
            if (_carService.Engineers.FindAll(c => c.ID == _engineer.ID).Count() <= 0)
            {
                _carService.Engineers.Add(_engineer);
                _storageHelper.SaveData(FILE_NAME, _carService);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CarF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_engineer == null)
            {
                _engineer = (Engineer)_engineerHandler.Create();
            }
            bsEngineer.DataSource = _engineer;

            SetDataBindings();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            SaveEngineer();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
