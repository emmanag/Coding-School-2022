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

namespace Gas_Station.Win.CustomerForms
{
    public partial class CustomerEditF : Form
    {
        private CustomerEditViewModel _customer;
        private HttpClient _client;

        public CustomerEditF(HttpClient client)
        {
            InitializeComponent();
            _client = client;
        }

        public CustomerEditF(HttpClient client, CustomerEditViewModel customer): this(client)
        {
            _customer = customer;
        }

        private void CustomerEditF_Load(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                _customer = new CustomerEditViewModel();
            }
           bsCustomer.DataSource = _customer;

            SetDataBindings();
        }

        private void SetDataBindings()
        {
            txtName.DataBindings.Add(new Binding("Text", bsCustomer, "Name", true));
            txtSurname.DataBindings.Add(new Binding("Text", bsCustomer, "Surname", true));
            txtCardNumber.DataBindings.Add(new Binding("Text", bsCustomer, "CardNumber", true));
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
                return;

            if(_customer.ID == Guid.Empty)
            {
                var response = await _client.PostAsJsonAsync("customer", _customer);
            }
            else
            {
                var response = await _client.PutAsJsonAsync("customer", _customer);
            }
            Close();
        }

        

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
