﻿using DataLibrary;
using Session_11.HelperFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class CarsF : Form
    {
        private CarService _carService;
        private Car _car;
        private CarHandler _carHandler;
        private StorageHelper _storageHelper;
        public CarsF(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
            _carHandler = new CarHandler();
            _storageHelper = new StorageHelper();
        }

        private void CarsF_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateCars();
        }

        private void PopulateControls()
        {
            
        }

        private void PopulateCars()
        {
            

            bsCars.DataSource = _carService;
            bsCars.DataMember = "Cars";

            GrdCars.DataSource = bsCars;
                        
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            var cars = bsCars.Current as Car;

            CarF carF = new CarF(_carService);
            carF.ShowDialog();
            gridView1.RefreshData();

        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            var cars = bsCars.Current as Car;

            CarF carF = new CarF(_carService, _car);
            carF.ShowDialog();
            gridView1.RefreshData();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {

            var car = bsCars.Current as Car;
            _carHandler.Delete(car, _carService.Cars);
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
    

