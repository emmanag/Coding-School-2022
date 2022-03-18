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
    public partial class TransactionF : Form
    {
        private CarService _carService;
        private Transaction _transaction;
        private TransactionHandler _transactionHandler;

        public TransactionF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _transactionHandler = new TransactionHandler();
        }

        /*public TransactionF(CarService carService, Transaction transaction)
        {
            InitializeComponent();
            _carService=carService;
            _transaction=transaction;
            _transactionHandler = new TransactionHandler();
        }*/

        public TransactionF(CarService carService, Transaction transaction)
        {
            _transaction = transaction;
        }


        #region UI Controls
        private void TransactionF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_transaction == null)
            {
                _transaction = (Transaction)_transactionHandler.Create();
            }
            bsTransaction.DataSource = _transaction;

            SetDataBindings();
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

            CtrlcustomerID.DataBindings.Add(new Binding("EditValue", bsTransaction, "CustomerID", true));
            CtrlmanagerID.DataBindings.Add(new Binding("EditValue",bsTransaction,"ManagerID",true));
            CtrlcarID.DataBindings.Add(new Binding("EditValue",bsTransaction,"CarID",true));
        }

        private void PopulateControls()
        {

        }

        private void SaveTransaction()
        {
            _carService.Transactions.Add(_transaction);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
