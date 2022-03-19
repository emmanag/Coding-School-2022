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
        
        public TransactionsF(CarService carServise)
        {
            InitializeComponent();
            _carService = carServise;
            _selectedTransaction = new Transaction();
            _transactionHandler = new TransactionHandler();
            _controlsHelper = new ControlsHelper();
        }

        private void TransactionsF_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateTransactions();
        }

        private void PopulateControls()
        {

        }

        private void PopulateTransactions()
        {
            bsTransactions.DataSource = _carService;
            bsTransactions.DataMember = "Transactions";

            GrdTransactions.DataSource = bsTransactions;   
            
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            TransactionF transactionF = new TransactionF(_carService);
            transactionF.ShowDialog();
            gridView1.RefreshData();

        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            _selectedTransaction = bsTransactions.Current as Transaction;

            TransactionF transactionF = new TransactionF(_carService, _selectedTransaction);
            transactionF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            //TODO Delete an current object form the grid
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
