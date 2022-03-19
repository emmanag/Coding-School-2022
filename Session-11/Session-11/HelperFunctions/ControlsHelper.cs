using DataLibrary;
using DataLibrary.DataClasses;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11.HelperFunctions
{
    public class ControlsHelper
    {
        public ControlsHelper()
        {

        }

        public void PopulateManagers(RepositoryItemLookUpEdit lookup, List<Manager> list)
        {
            lookup.DataSource = list;
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"));
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"));
            lookup.DisplayMember = "FullName";
            lookup.ValueMember = "ID";
        }

        public void PopulateEngineers(RepositoryItemLookUpEdit lookup, List<Engineer> list)
        {
            lookup.DataSource = list;
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"));
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"));
            lookup.DisplayMember = "FullName";
            lookup.ValueMember = "ID";
        }

        public void PopulateCars(RepositoryItemLookUpEdit lookup, List<Car> list)
        {
            lookup.DataSource = list;
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand"));
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", "Model"));
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarRegNumber", "CarRegNumber"));
            lookup.DisplayMember = "CarRegNumber";
            lookup.ValueMember = "ID";
        }

        public void PopulateCustomers(RepositoryItemLookUpEdit lookup, List<Customer> list)
        {
            lookup.DataSource = list;
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"));
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"));
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Phone", "Phone"));
            lookup.DisplayMember = "FullName";
            lookup.ValueMember = "ID";
        }

        public void PopulateServiceTasks(RepositoryItemLookUpEdit lookup, List<ServiceTask> list)
        {
            lookup.DataSource = list;
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description"));
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Hours", "Hours"));
            lookup.DisplayMember = "Code";
            lookup.ValueMember = "ID";
        }

        public void PopulateAccounts(RepositoryItemLookUpEdit lookup, List<Credential> list)
        {
            lookup.DataSource = list;
            lookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username"));
            lookup.DisplayMember = "Username";
            lookup.ValueMember = "ID";
        }


        public void PopulateCarColumns(RepositoryItemLookUpEdit lookUpEdit, BindingSource binding, List<Car> list)
        {
            binding.DataSource = list;
            lookUpEdit.DataSource = binding;
           
            lookUpEdit.DisplayMember = "CarRegNumber";
            lookUpEdit.ValueMember = "ID";
            lookUpEdit.ReadOnly = true;
        }

        public void PopulateCustomerColumns(RepositoryItemLookUpEdit lookUpEdit, BindingSource binding, List<Customer> list)
        {
            binding.DataSource = list;
            lookUpEdit.DataSource = binding;

            lookUpEdit.DisplayMember = "FullName";
            lookUpEdit.ValueMember = "ID";
            lookUpEdit.ReadOnly = true;
        }

        public void PopulateManagerColumns(RepositoryItemLookUpEdit lookUpEdit, BindingSource binding, List<Manager> list)
        {
            binding.DataSource = list;
            lookUpEdit.DataSource = binding;

            lookUpEdit.DisplayMember = "FullName";
            lookUpEdit.ValueMember = "ID";
            lookUpEdit.ReadOnly = true;
        }

        public void SetColumn(RepositoryItemLookUpEdit columnLookUpEdit, DevExpress.XtraGrid.Views.Grid.GridView gridView, string indexColumn)
        {
            gridView.Columns[indexColumn].ColumnEdit = columnLookUpEdit;
        }
    }
}
