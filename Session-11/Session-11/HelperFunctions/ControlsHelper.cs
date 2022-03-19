using DataLibrary;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
