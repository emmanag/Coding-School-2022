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
    public partial class ServiceTasksF : Form
    {
        private CarService _carService;
        private ServiceTask _selectedServiceTask;
        private ServiceTaskHandler _serviceTaskHandler;
        private StorageHelper _storageHelper;
        private ControlsHelper _controlsHelper;

        public ServiceTasksF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _selectedServiceTask = new ServiceTask();
            _serviceTaskHandler = new ServiceTaskHandler();
            _storageHelper = new StorageHelper();
            _controlsHelper = new ControlsHelper();
        }

        private void ServiceTaskF_Load(object sender, EventArgs e)
        {
            
            PopulateServiceTask();
        }

        private void PopulateServiceTask()
        {
            bsServiceTasks.DataSource = _carService;
            bsServiceTasks.DataMember = "ServiceTasks";

            GrdServiceTasks.DataSource = bsServiceTasks;

            _controlsHelper.HideColumns("ID", gridView1);
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            ServiceTaskF serviceTaskF = new ServiceTaskF(_carService);
            serviceTaskF.ShowDialog();
            gridView1.RefreshData();

        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            _selectedServiceTask = bsServiceTasks.Current as ServiceTask;

            ServiceTaskF serviceTaskF = new ServiceTaskF(_carService, _selectedServiceTask);
            serviceTaskF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            var serviceTask = bsServiceTasks.Current as ServiceTask;
            _serviceTaskHandler.Delete(serviceTask, _carService.ServiceTasks);
            _storageHelper.SaveData("storage.json", _carService);
            gridView1.RefreshData();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
