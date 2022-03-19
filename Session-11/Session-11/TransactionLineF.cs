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
    public partial class TransactionLineF : Form
    {
        private const string FILE_NAME = "storage.json";
        private Transaction _transaction;
        private TransactionLine _transactionLine;
        private TransactionLineHandler _transactionLineHandler;
        private StorageHelper _storageHelper;
        private ControlsHelper _controlsHelper;
        private CarService _carService;

        public TransactionLineF(Transaction transaction, CarService carService)
        {
            InitializeComponent();
            _transaction = transaction;
            _transactionLineHandler = new TransactionLineHandler();
            _storageHelper = new StorageHelper();
            _controlsHelper = new ControlsHelper();
            _carService = carService;
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
            Ctrlhours.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "Hours", true));  
            Ctrlprice.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "Price", true));
            Ctrlpriceperhour.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "PricePerHour", true));


            CtrlengineerID.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "EngineerID",true));
            CtrlservicetaskID.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "ServiceTaskID", true));
            //CtrltransactionID.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "ServiceTaskID", true));
            CtrltransactionID.EditValue = _transaction.ID;
        }

        private void PopulateControls()
        {
            _controlsHelper.PopulateServiceTasks(CtrlservicetaskID.Properties, _carService.ServiceTasks);
            _controlsHelper.PopulateEngineers(CtrlengineerID.Properties, _carService.Engineers.FindAll(e => e.Status == StatusEnum.Free));
        }

        private void SaveTransactionLine()
        {
            _transaction.TransactionLines.Add(_transactionLine);
            DialogResult = DialogResult.OK;
            Close();
        }
        
    }
}
