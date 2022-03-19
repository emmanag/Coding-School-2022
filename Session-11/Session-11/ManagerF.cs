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
    public partial class ManagerF : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private Manager _manager;
        private ManagerHandler _managerHandler;
        private StorageHelper _storageHelper;
        public ManagerF(CarService carService)
        {
            
            InitializeComponent();
            _carService = carService;
            _managerHandler = new ManagerHandler();
            _storageHelper = new StorageHelper();
        }

        public ManagerF(CarService carService, Manager manager) : this(carService)
        {
            _manager = manager;
        }

        private void ManagerF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_manager == null)
            {
                _manager = (Manager)_managerHandler.Create();
            }
            bsManager.DataSource = _manager;

            SetDataBindings();
        }

        private void SetDataBindings()
        {
            Ctrlname.DataBindings.Add(new Binding("EditValue", bsManager, "Name", true));
            Ctrlsurname.DataBindings.Add(new Binding("EditValue", bsManager, "Surname", true));
            Ctrlsallarypermonth.DataBindings.Add(new Binding("EditValue", bsManager, "SallaryPerMonth", true));
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            SaveManager();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PopulateControls()
        {

        }

        private void SaveManager()
        {
            if (_carService.Managers.FindAll(c => c.ID == _manager.ID).Count() <= 0)
            {
                _carService.Managers.Add(_manager);
                _storageHelper.SaveData(FILE_NAME, _carService);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
