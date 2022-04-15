using Gas_Station.Model;
using Gas_Station.Shared.ViewModels;
using Gas_Station.Win.CustomerForms;
using Gas_Station.Win.ItemForms;
using Gas_Station.Win.TransactionFomrs;
using Handler;
using System.Net.Http;

namespace Gas_Station.Win
{
    public partial class HomeF : Form
    {
        private TransactionHandler _handler;
        private HttpClient _httpClient;
        private LoginViewModel _login;
        public HomeF(HttpClient httpClient, LoginViewModel login)
        {
            InitializeComponent();
            _handler = new TransactionHandler();
            _login = login;            
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7296/");
            HideButtons();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new CustomersListF( _httpClient);
            frmCustomerList.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new ItemListF(_httpClient);
            frmCustomerList.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new TransactionList(_httpClient, _handler);
            frmCustomerList.ShowDialog();
        }
        private void HideButtons()
        {
            if (_login.EmployeeType == EmployeeType.Cashier)
            {
                itemsToolStripMenuItem.Visible = false;
                return;
            }
            if (_login.EmployeeType == EmployeeType.Staff)
            {
                customersToolStripMenuItem.Visible = false;
                transactionsToolStripMenuItem.Visible = false;
                return;
            }

        }
        private void HomeF_Load(object sender, EventArgs e)
        {

        }
    }
}