using Gas_Station.Model;
using Gas_Station.Shared;
using Gas_Station.Shared.ViewModels;
using Gas_Station.Win.TransactionLineForms;
using Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gas_Station.Win.TransactionForms
{
    public partial class TransactionEditF : Form
    {
        private HttpClient _client;
        private TransactionEditViewModel _transaction;
        private List<EmployeeListViewModel> _currEmployees;
        private TransactionLineEditViewModel _selectedTransactionLine;
        private TransactionHandler _handler;
        public TransactionEditF(HttpClient httpClient, TransactionHandler handler)
        {
            InitializeComponent();
            _client = httpClient;
            _handler = handler;
        }

        public TransactionEditF(HttpClient httpClient, TransactionEditViewModel transaction, TransactionHandler handler) : this(httpClient, handler)
        {
            _transaction = transaction;
        }

        private async void TransactionEditF_Load(object sender, EventArgs e)
        {
            if (_transaction == null)
            {
                _transaction = new TransactionEditViewModel();
                _transaction.TransactionLineList = new();

            }
            await LoadFormServerEmployeeList();
            await LoadFromServerCustomer();

            bsTransaction.DataSource = _transaction;
            bsTransactionLine.DataSource = _transaction.TransactionLineList;

            SetReadOnlyFields();



            SetDataBindings();

            RefreshGridViewTransactionList();
        }

        private void SetDataBindings()
        {

            txtCustomerName.DataBindings.Add(new Binding("Text", bsTransaction, "CustomerFullName", true));
            txtTotalValue.DataBindings.Add(new Binding("Text", bsTransaction, "TotalValue", true));


            //TODO elen3e an ta bindings einai swsta
            RefreshEmployeeList();
            ctrEmployee.DataBindings.Add(new Binding("Text", bsTransaction, "EmployeeFullName", true));

            string[] payMethod = Enum.GetNames(typeof(PaymentMethod));
            ctrPayMethod.Items.AddRange(payMethod);

            ctrPayMethod.DataBindings.Add(new Binding("Text", bsTransaction, "PayMentMethod", true));
        }

        private async Task LoadFormServerEmployeeList()
        {
            var employees = await _client.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
            _currEmployees = employees.Where(e => e.HireDateStart <= DateTime.Now &&
                e.HireDateEnd > DateTime.Now && e.EmployeeType != EmployeeType.Staff).ToList();

        }

        private async Task LoadFromServerCustomer()
        {
            var tmp = await _client.GetFromJsonAsync<CustomerEditListViewModel>($"customer/{_transaction.CustomerID}");
            if (tmp is null) return;
            _transaction.CustomerFullName = $"{tmp.Name} {tmp.Surname}";
        }

        private EmployeeListViewModel LoadSelectedEmployee(int selectedIndex)
        {
            return _currEmployees.ElementAt(selectedIndex);
        }

        private void SetReadOnlyFields()
        {
            txtCustomerName.ReadOnly = true;
            txtTotalValue.ReadOnly = true;
            grvTransactionLine.ReadOnly = true;
        }

        private void RefreshEmployeeList()
        {
            ctrEmployee.DataSource = null;
            ctrEmployee.DataSource = _currEmployees;
            ctrEmployee.DisplayMember = "Name";
            ctrEmployee.ValueMember = "Id";
        }

        private async void bntRefresh_Click(object sender, EventArgs e)
        {
            await LoadFormServerEmployeeList();
            RefreshEmployeeList();
            RefreshGridViewTransactionList();
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(ctrEmployee.Text) ||
                string.IsNullOrWhiteSpace(ctrPayMethod.Text))
                return;
            
            HttpResponseMessage response;
            _transaction.EmployeeID = LoadSelectedEmployee(ctrEmployee.SelectedIndex).ID;
            if (_transaction.ID == Guid.Empty)
            {
                response = await _client.PostAsJsonAsync("transaction", _transaction);
            }
            else
            {
                response = await _client.PutAsJsonAsync("transaction", _transaction);
            }
            response.EnsureSuccessStatusCode();
            Close();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void bntAddTL_Click(object sender, EventArgs e)
        {
            var transacationLineF = new TransactionLineF(_client, _transaction, _handler);
            transacationLineF.ShowDialog();
            RefreshGridViewTransactionList();
        }

        private async void bntDeleteTL_Click(object sender, EventArgs e)
        {
            if (grvTransactionLine.SelectedRows.Count != 1)
                return;

            _selectedTransactionLine = (TransactionLineEditViewModel)grvTransactionLine.SelectedRows[index: 0].DataBoundItem;
            _transaction.TransactionLineList.Remove(_selectedTransactionLine);
            RefreshGridViewTransactionList();
        }

        private async void RefreshGridViewTransactionList()
        {
            grvTransactionLine.DataSource = null;

            grvTransactionLine.DataSource = bsTransactionLine;

            grvTransactionLine.Columns["TransactionID"].Visible = false;
            grvTransactionLine.Columns["ID"].Visible = false;
            grvTransactionLine.Columns["ItemID"].Visible = false;

            TotalValueCalc();
        }

        private void TotalValueCalc()
        {
            _transaction.TotalValue = _handler.CalculateTransactionTotalValue(_transaction.TransactionLineList);
            txtTotalValue.Text = _transaction.TotalValue.ToString();
            SetPaymentMethod(_transaction.TotalValue);
        }
        private void SetPaymentMethod(decimal totalValue)
        {
            ctrPayMethod.Enabled = true;
            if (!_handler.CheckCardPaymentAvail(totalValue))
            {
                ctrPayMethod.SelectedIndex = 2;
                ctrPayMethod.Enabled = false;
            }
        }
    }
}
