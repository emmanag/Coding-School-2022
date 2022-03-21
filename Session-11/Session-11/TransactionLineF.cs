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
    public partial class TransactionLineF : Form
    {
        private const string FILE_NAME = "storage.json";
        private Transaction _transaction;
        private TransactionLine _transactionLine;
        private TransactionLineHandler _transactionLineHandler;
        private TransactionHandler _transactionHandler;
        private StorageHelper _storageHelper;
        private ControlsHelper _controlsHelper;
        private CarService _carService;
        private CarServiceHandler _carServiceHandler;

        public TransactionLineF(Transaction transaction, CarService carService)
        {
            InitializeComponent();
            _transaction = transaction;
            _transactionLineHandler = new TransactionLineHandler();
            _storageHelper = new StorageHelper();
            _controlsHelper = new ControlsHelper();
            _carService = carService;
            _transactionHandler = new TransactionHandler();
            _carServiceHandler = new CarServiceHandler();
            _transactionLine = new TransactionLine();
        }


        #region UI Controls

        private void TransactionLineF_Load(Object sender, EventArgs e)
        {
            PopulateControls();

            if (_transactionLine == null)
            {
                _transactionLine = (TransactionLine)_transactionLineHandler.Create();
            }
            bsTransactionLine.DataSource = _transactionLine;

            SetDataBindings();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please fill the empty fields", "Warning");
                return;
            }
            SaveTransactionLine();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        private void SetDataBindings()
        {
            CtrlengineerID.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "EngineerID",true));
            CtrlservicetaskID.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "ServiceTaskID", true));
        }

        private void PopulateControls()
        {
            _controlsHelper.PopulateServiceTasks(CtrlservicetaskID.Properties, _carService.ServiceTasks);
            _controlsHelper.PopulateEngineers(CtrlengineerID.Properties, _carService.Engineers.FindAll(e => e.Status == StatusEnum.Free));
        }

        private void SaveTransactionLine()
        {
            _transactionHandler.AddNewTransactionLine(_transaction, _transactionLine, _carServiceHandler, _carService);
            _transactionLine.Price = _transactionLineHandler.CalcTaskCost(_transactionLine, _carService.ServiceTasks.Find(s => s.ID == _transactionLine.ServiceTaskID));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CtrlservicetaskID_EditValueChanged(object sender, EventArgs e)
        {
            if ((Guid)CtrlservicetaskID.EditValue == Guid.Empty)
            {
                return;
            }
            _transactionLine.Hours = _carService.ServiceTasks.Find(s => s.ID.ToString() == CtrlservicetaskID.EditValue.ToString()).Hours;

        }

        private void CtrlservicetaskID_Validating(object sender, CancelEventArgs e)
        {
            if (_carService.ServiceTasks.FirstOrDefault(st => st.ID.ToString() == CtrlservicetaskID.EditValue.ToString()) == null)
            {
                e.Cancel = true;
                CtrlservicetaskID.Focus();
                errorProvider1.SetError(CtrlservicetaskID, "Service Task should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CtrlservicetaskID, "");
            }
        }

        private void CtrlengineerID_Validating(object sender, CancelEventArgs e)
        {
            if (_carService.Engineers.FirstOrDefault(en => en.ID.ToString() == CtrlengineerID.EditValue.ToString()) == null)
            {
                e.Cancel = true;
                CtrlengineerID.Focus();
                errorProvider1.SetError(CtrlengineerID, "Engineer should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CtrlengineerID, "");
            }
        }
    }
}
