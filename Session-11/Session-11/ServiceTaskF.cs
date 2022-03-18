﻿using DataLibrary;
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
    public partial class ServiceTaskF : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private ServiceTask _serviceTask;
        private ServiceTaskHandler _serviceTaskHandler;
        private StorageHelper _storageHelper;

        public ServiceTaskF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _storageHelper= new StorageHelper();
            _serviceTaskHandler = new ServiceTaskHandler();
        }

        public ServiceTaskF(CarService carService, ServiceTask service) : this(carService)
        {
            _serviceTask = service;
        }


        #region UI Controls
        private void ServiceTaskF_Load(object sender, EventArgs e)
        {
            PopulateControls();

            if (_serviceTask == null)
            {
                _serviceTask = (ServiceTask)_serviceTaskHandler.Create();
            }
            bsServiceTask.DataSource = _serviceTask;

            SetDataBindings();
        }


        private void Btnsave_Click(object sender, EventArgs e)
        {
            SaveServiceTask();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        private void SetDataBindings()
        {
            Ctrlcode.DataBindings.Add(new Binding("EditValue", bsServiceTask, "Code", true));
            Ctrldescription.DataBindings.Add(new Binding("EditValue", bsServiceTask, "Description", true));
            Ctrlhours.DataBindings.Add(new Binding("EditValue", bsServiceTask, "Hours", true));
        }

        private void PopulateControls()
        {

        }

        private void SaveServiceTask()
        {
            _carService.ServiceTasks.Add(_serviceTask);
            _storageHelper.SaveData(FILE_NAME, _carService);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
