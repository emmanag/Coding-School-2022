using DataLibrary;
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
        private CarService _carService;
        private TransactionLine _transactionLine;
        private TransactionLineHandler _transactionLineHandler;

        public TransactionLineF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _transactionLineHandler = new TransactionLineHandler();
        }

        /*public TransactionLineF(CarService carService, TransactionLine transactionLine)
        {
            InitializeComponent();
            _carService=carService;
            _transaction=transactionLine;
            _transactionHandler = new TransactionLineHandler();
        }*/

        public TransactionLineF(CarService carService, TransactionLine transactionLine)
        {
            _transactionLine = transactionLine;
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
            CtrltransactionID.DataBindings.Add(new Binding("EditValue", bsTransactionLine, "ServiceTaskID", true));
          
        }

        private void PopulateControls()
        {

        }

        private void SaveTransactionLine()
        {
            _carService.TransactionLines.Add(_transactionLine);
            DialogResult = DialogResult.OK;
            Close();
        }
        
    }
}
