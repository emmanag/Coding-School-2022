using System;
using DataLibrary;
using Session_11.HelperFunctions;
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
    public partial class TransactionsF : Form
    {
        private CarService _carService;
        private Transaction _selectedTransaction;
        private TransactionHandler _transactionHandler;
        private ControlsHelper _controlsHelper;
        private StorageHelper _storageHelper;
        
        public TransactionsF(CarService carServise)
        {
            InitializeComponent();
            _carService = carServise;
            _selectedTransaction = new Transaction();
            _transactionHandler = new TransactionHandler();
            _controlsHelper = new ControlsHelper();
            _storageHelper = new StorageHelper();
        }

        private void TransactionsF_Load(object sender, EventArgs e)
        {
            
            PopulateTransactions();
            PopulateControls();
        }

        private void PopulateControls()
        {
            _controlsHelper.PopulateCarsColumns(CarLookUp, bsCarColumns, _carService.Cars);
            _controlsHelper.PopulateCustomersColumns(CustomerLookUp, bsCustomerColumns, _carService.Customers);
            _controlsHelper.PopulateManagersColumns(ManagerLookUp, bsManagerColumns, _carService.Managers);
            
            _controlsHelper.SetColumn(CarLookUp,gridView1, "CarID");
            _controlsHelper.SetColumn(CustomerLookUp, gridView1, "CustomerID");
            _controlsHelper.SetColumn(ManagerLookUp, gridView1, "ManagerID");

        }

        private void PopulateTransactions()
        {
           
            bsTransactions.DataSource = _carService;
            bsTransactions.DataMember = "Transactions";
            GrdTransactions.DataSource = bsTransactions;

            _controlsHelper.HideColumns("ID", gridView1);   
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            TransactionF transactionF = new TransactionF(_carService);
            transactionF.ShowDialog();
            gridView1.RefreshData();

        }

        //private void Btnedit_Click(object sender, EventArgs e)
        //{
        //    _selectedTransaction = bsTransactions.Current as Transaction;

        //    TransactionF transactionF = new TransactionF(_carService, _selectedTransaction);
        //    transactionF.ShowDialog();
        //    gridView1.RefreshData();
        //}

        private void Btndelete_Click(object sender, EventArgs e)
        {
            var transaction = bsTransactions.Current as Transaction;
            _transactionHandler.Delete(transaction, _carService.Transactions);
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
