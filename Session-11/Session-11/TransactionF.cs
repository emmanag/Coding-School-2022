using DataLibrary;
using DataLibrary.ItemHandlers;
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
        private TransactionLineHandler _transactionLineHandler;
        private StorageHelper _storageHelper;
        private MessagesHelper _messagesHelper;
        private ControlsHelper _controlsHelper;

        public TransactionF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _transactionHandler = new TransactionHandler();
            _storageHelper = new StorageHelper();
            _transaction = new Transaction();
            _messagesHelper = new MessagesHelper();
            _transactionLineHandler = new TransactionLineHandler();
            _controlsHelper = new ControlsHelper();
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
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please fill the empty fields", "Warning");
                return;
            }
            SaveTransaction();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            foreach (var line in _transaction.TransactionLines)
            {
                _carService.Engineers.Find(en => en.ID == line.EngineerID).Status = StatusEnum.Free;
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        private void SetDataBindings()
        {
            Ctrldate.DataBindings.Add(new Binding("EditValue", bsTransaction, "Date", true));
            Ctrltotalprice.DataBindings.Add(new Binding("EditValue", bsTransaction, "TotalPrice", true));

            CtrlCustomer.DataBindings.Add(new Binding("EditValue", bsTransaction, "CustomerID", true));
            CtrlManager.DataBindings.Add(new Binding("EditValue", bsTransaction, "ManagerID", true));
            CtrlCar.DataBindings.Add(new Binding("EditValue", bsTransaction, "CarID", true));
            
        }

        private void PopulateControls()
        {
            bsTransactionLines.DataSource = _transaction.TransactionLines;
            grdTransLines.DataSource = bsTransactionLines;
            _controlsHelper.PopulateServiceTaskID(colServiceTaskID, bsServiveTask, _carService.ServiceTasks);
            _controlsHelper.PopulateEngineersID(colEngineerID, bsTransID, _carService.Engineers);

            _controlsHelper.SetColumn(colServiceTaskID, grvTransLines, "ServiceTaskID");
            _controlsHelper.SetColumn(colEngineerID, grvTransLines, "EngineerID");
            _controlsHelper.HideColumns("TransactionID", grvTransLines);
            _controlsHelper.HideColumns("ID", grvTransLines);
        }

        private void SaveTransaction()
        {
            if (_carService.Transactions.FindAll(c => c.ID == _transaction.ID).Count() <= 0)
            {
                _transaction.TotalPrice = _transactionHandler.GetTransactionPrice(_transaction);
                _carService.Transactions.Add(_transaction);
                _storageHelper.SaveData(FILE_NAME, _carService);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAddLine_Click(object sender, EventArgs e)
        {
            if (_transactionHandler.CheckEngineersAvail(_carService.Engineers))
            {
                var form = new TransactionLineF(_transaction, _carService);
                form.ShowDialog();
                grvTransLines.RefreshData();
                Ctrltotalprice.EditValue = _transactionHandler.GetTransactionPrice(_transaction);

            }
            else
            {
                _messagesHelper.MessageInfo("There are no available engineers.");
            }
        }

        private void buttonRemoveLine_Click(object sender, EventArgs e)
        {
            var transactionLine = bsTransactionLines.Current as TransactionLine;
            _transactionLineHandler.Delete(transactionLine, _transaction.TransactionLines, _carService);
            grvTransLines.RefreshData();

        }

        private void CtrlCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (_carService.Customers.FirstOrDefault(c => c.ID.ToString() == CtrlCustomer.EditValue.ToString()) == null)
            {
                e.Cancel = true;
                CtrlCustomer.Focus();
                errorProvider1.SetError(CtrlCustomer, "Customer should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CtrlCustomer, "");
            }
        }

        private void CtrlCar_Validating(object sender, CancelEventArgs e)
        {
            if (_carService.Cars.FirstOrDefault(c => c.ID.ToString() == CtrlCar.EditValue.ToString()) == null)
            {
                e.Cancel = true;
                CtrlCar.Focus();
                errorProvider1.SetError(CtrlCar, "Car should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CtrlCar, "");
            }
        }

        private void CtrlManager_Validating(object sender, CancelEventArgs e)
        {
            if (_carService.Managers.FirstOrDefault(m => m.ID.ToString() == CtrlManager.EditValue.ToString()) == null)
            {
                e.Cancel = true;
                CtrlManager.Focus();
                errorProvider1.SetError(CtrlManager, "Manager should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CtrlManager, "");
            }
        }
    }
}
