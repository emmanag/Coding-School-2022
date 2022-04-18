using Gas_Station.Shared;
using Gas_Station.Shared.ViewModels;
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
    public partial class CardNumberF : Form
    {
        private TransactionHandler _handler;
        private string _cardNumber;
        private HttpClient _client;

        public CardNumberF(HttpClient client, TransactionHandler handler)
        {
            InitializeComponent();
            _client = client;
            _handler = handler;
        }

        private async void bntContiue_Click(object sender, EventArgs e)
        {
            _cardNumber = txtName.Text;

           

            this.Close();

            var customers = await _client.GetFromJsonAsync<List<CustomerEditListViewModel>>("customer");
            var existingCustomer = customers.SingleOrDefault(c => c.CardNumber.Equals(_cardNumber));
            if (existingCustomer is null)
            {
                var newCustomer = new CustomerEditListViewModel()
                {
                    CardNumber = _cardNumber,
                };
                var frameNewCustomer = new CustomerForms.CustomerEditF(_client, convertViewtoEdit(newCustomer));
                frameNewCustomer.ShowDialog();

                

                customers = await _client.GetFromJsonAsync<List<CustomerEditListViewModel>>("customer");
                existingCustomer = customers.SingleOrDefault(c => c.CardNumber.Equals(_cardNumber));
                
                if (existingCustomer is null) this.Close();
                
                OpenTransaction(existingCustomer);

            }
            else
            {
                OpenTransaction(existingCustomer);
            }
        }

        

        private void OpenTransaction(CustomerEditListViewModel mycustomer)
        {
            var transaction = new TransactionEditViewModel()
            {
                CustomerID = mycustomer.ID,
                TotalValue = 0,
                TransactionLineList = new()
            };
            var frameNewCustomer = new TransactionEditF(_client, transaction, _handler);
            frameNewCustomer.ShowDialog();
        }

        private CustomerEditViewModel convertViewtoEdit(CustomerEditListViewModel mycustomer)
        {
            var editcustomer = new CustomerEditViewModel()
            {
                ID = mycustomer.ID,
                Name = mycustomer.Name,
                Surname = mycustomer.Surname,
                CardNumber = mycustomer.CardNumber
            };
            return editcustomer;
        }
    }
}
