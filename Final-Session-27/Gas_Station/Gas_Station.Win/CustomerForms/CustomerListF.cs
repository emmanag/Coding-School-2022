using Gas_Station.Shared;
using Gas_Station.Shared.ViewModels;
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
using static System.Net.Http.HttpClient;

namespace Gas_Station.Win.CustomerForms
{
    public partial class CustomersListF : Form
    {

        private HttpClient _client;
        private List<CustomerEditListViewModel> _customerList;
        private CustomerEditViewModel _selectedCustomer;

        public CustomersListF(HttpClient myhttpClient)
        {
            InitializeComponent();
            _client = myhttpClient;

        }

        private async Task LoadItemsFromServer()
        {
            _customerList = await _client.GetFromJsonAsync<List<CustomerEditListViewModel>>("customer");
        }

        private async Task RefreshCustomerList()
        {
            grvCustomerList.DataSource = null;

            await LoadItemsFromServer();
            grvCustomerList.DataSource = _customerList;

            grvCustomerList.Update();
            grvCustomerList.Refresh();
            grvCustomerList.Columns["ID"].Visible = false;
        }


        private async void CustomerListF_Load(object sender, EventArgs e)
        {
            await RefreshCustomerList();

            grvCustomerList.ReadOnly = true;

        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new CustomerEditF(_client);
            frmCustomerList.ShowDialog();
            await RefreshCustomerList();
        }

        private async void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (grvCustomerList.SelectedRows.Count != 1)
                return;

            _selectedCustomer = ConvertViewToEdit((CustomerEditListViewModel)grvCustomerList.SelectedRows[index: 0].DataBoundItem);
            var frmCustomerList = new CustomerEditF(_client, _selectedCustomer);
            frmCustomerList.ShowDialog();
            await RefreshCustomerList();
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (grvCustomerList.SelectedRows.Count != 1)
                return;

            _selectedCustomer = ConvertViewToEdit((CustomerEditListViewModel)grvCustomerList.SelectedRows[index: 0].DataBoundItem);
            _client.DeleteAsync($"customer/{_selectedCustomer.ID}");
            await RefreshCustomerList();
        }

        private async void bntRefresh_Click(object sender, EventArgs e)
        {
            await RefreshCustomerList();
        }
        private CustomerEditViewModel ConvertViewToEdit(CustomerEditListViewModel model)
        {
            return new CustomerEditViewModel()
            {
                ID = model.ID,
                CardNumber = model.CardNumber,
                Name = model.Name,
                Surname = model.Surname,
            };
        }

        private void grvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
