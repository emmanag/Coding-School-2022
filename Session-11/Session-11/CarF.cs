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
    public partial class CarF : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private Car _car;
        private CarHandler _carHandler;
        private StorageHelper _storageHelper;

        public CarF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _carHandler = new CarHandler();
            _storageHelper = new StorageHelper();
        }

        public CarF(CarService carService, Car car) : this(carService)
        {
            _car = car;
        }

        #region UI Controls

        private void CarF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_car == null)
            {
                _car = (Car)_carHandler.Create();
            }
            bsCar.DataSource = _car;

            SetDataBindings();
        }
        
        private void Btnsave_Click(object sender, EventArgs e)
        {
            SaveCar();
        }
        
        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        private void SetDataBindings()
        {
            Ctrlbrand.DataBindings.Add(new Binding("EditValue", bsCar, "Brand", true));
            Ctrlmodel.DataBindings.Add(new Binding("EditValue", bsCar, "Model", true));
            Ctrlcarregistrationnumber.DataBindings.Add(new Binding("EditValue", bsCar, "CarRegNumber", true));
        }

        private void PopulateControls()
        {

        }

        private void SaveCar()
        {
            if (_carService.Cars.FindAll(c => c.ID == _car.ID).Count() <= 0 )
            {
                _carService.Cars.Add(_car);
                _storageHelper.SaveData(FILE_NAME, _carService);
               
            }

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
