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
    public partial class CustomerF : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private Customer _customer;
        private CustomerHandler _customerHandler;
        private StorageHelper _storageHelper;

        public CustomerF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _customerHandler = new CustomerHandler();
            _storageHelper = new StorageHelper();
        }

        public CustomerF(CarService carService, Customer customer) : this(carService)
        {
            _customer = customer;
        }

        private void CustomerF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_customer == null)
            {
                _customer = (Customer)_customerHandler.Create();
            }
            bsCustomer.DataSource = _customer;

            SetDataBindings();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please fill the empty fields", "Warning");
            }
            else
            {
                SaveCustomer();
            }
            
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SetDataBindings()
        {
            Ctrlname.DataBindings.Add(new Binding("EditValue", bsCustomer, "Name", true));
            Ctrlsurname.DataBindings.Add(new Binding("EditValue", bsCustomer, "Surname", true));
            Ctrlphone.DataBindings.Add(new Binding("EditValue", bsCustomer, "Phone", true));
            CtrlTIN.DataBindings.Add(new Binding("EditValue", bsCustomer, "TIN", true));

        }
        private void PopulateControls()
        {

        }

        private void SaveCustomer()
        {
            if (_carService.Customers.FindAll(c => c.ID == _customer.ID).Count() <= 0)
            {
                _carService.Customers.Add(_customer);
                _storageHelper.SaveData(FILE_NAME, _carService);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Ctrlname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ctrlname.Text))
            {
                e.Cancel = true;
                Ctrlname.Focus();
                errorProvider1.SetError(Ctrlname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Ctrlname, "");
            }
        }

        private void Ctrlsurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ctrlsurname.Text))
            {
                e.Cancel = true;
                Ctrlsurname.Focus();
                errorProvider1.SetError(Ctrlsurname, "Surname should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Ctrlsurname, "");
            }
        }

        private void Ctrlphone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ctrlphone.Text))
            {
                e.Cancel = true;
                Ctrlphone.Focus();
                errorProvider1.SetError(Ctrlphone, "Phone should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Ctrlphone, "");
            }
        }

        private void CtrlTIN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CtrlTIN.Text))
            {
                e.Cancel = true;
                CtrlTIN.Focus();
                errorProvider1.SetError(CtrlTIN, "TIN should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CtrlTIN, "");
            }
        }
    }
}
