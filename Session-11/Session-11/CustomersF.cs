using DataLibrary;
using DataLibrary.ItemHandlers;
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
    public partial class CustomersF : Form
    {
        private CarService _carService;
        private Customer _customer;
        private CustomerHandler _customerHandler;
        public CustomersF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _customerHandler = new CustomerHandler();
        }

        private void CarsF_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateCustomers();
        }

        private void PopulateControls()
        {

        }

        private void PopulateCustomers()
        {
            

            bsCustomers.DataSource = _carService;
            bsCustomers.DataMember = "Customers";

            GrdCustomers.DataSource = bsCustomers;

        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            var customers = bsCustomers.Current as Customer;

            CustomerF customerF = new CustomerF(_carService);
            customerF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            var cars = bsCustomers.Current as Customer;

            CustomerF customerF = new CustomerF(_carService, _customer);
            customerF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {

            //var customer = bsCustomers.Current as Customer;
            //_customerHandler.Delete; (customer, _carService.Customers)
            //SaveData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
