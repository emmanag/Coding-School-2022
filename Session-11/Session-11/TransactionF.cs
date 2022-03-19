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
    public partial class TransactionF : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private Transaction _transaction;
        private TransactionHandler _transactionHandler;
        private StorageHelper _storageHelper;

        public TransactionF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _transactionHandler = new TransactionHandler();
            _storageHelper = new StorageHelper();
        }

        
        public TransactionF(CarService carService, Transaction transaction) : this(carService)
        {
            _transaction = transaction;
        }


        #region UI Controls
        private void TransactionF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_transaction == null)
            {
                _transaction = (Transaction)_transactionHandler.CreateWithDateTimeToday();
            }
            bsTransaction.DataSource = _transaction;

            SetDataBindings();

            var controlHelper = new ControlsHelper();
            controlHelper.PopulateManagers(CtrlManager.Properties, _carService.Managers);
            controlHelper.PopulateCars(CtrlCar.Properties, _carService.Cars);
            controlHelper.PopulateCustomers(CtrlCustomer.Properties, _carService.Customers);
        }
        private void Btnsave_Click(object sender, EventArgs e)
        {
             SaveTransaction();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        private void SetDataBindings()
        {
            Ctrldate.DataBindings.Add(new Binding("EditValue", bsTransaction, "Date", true));
            Ctrltotalprice.DataBindings.Add(new Binding("EditValue", bsTransaction, "TotalPrice", true));

            CtrlCustomer.DataBindings.Add(new Binding("EditValue", bsTransaction, "CustomerID", true));
            CtrlManager.DataBindings.Add(new Binding("EditValue",bsTransaction,"ManagerID",true));
            CtrlCar.DataBindings.Add(new Binding("EditValue",bsTransaction,"CarID",true));
        }

        private void PopulateControls()
        {

        }

        private void SaveTransaction()
        {
            if (_carService.Transactions.FindAll(c => c.ID == _transaction.ID).Count() <= 0)
            {
                _carService.Transactions.Add(_transaction);
                _storageHelper.SaveData(FILE_NAME, _carService);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
