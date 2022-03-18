﻿using DataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Session_11.HelperFunctions;

namespace Session_11
{
    public partial class CarCenter : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private StorageHelper _storageHelper;
        private MessagesHelper _messagesHelper;

        public CarCenter()
        {
            InitializeComponent();
            _storageHelper = new StorageHelper();
            _messagesHelper = new MessagesHelper();
<<<<<<< HEAD
            _carService = new CarService()
            {
                Cars = new List<Car>()
                {
                    new Car()
                    {
                        Brand = "Ford",
                        Model = "2003",
                        CarRegNumber = 234321
                    },
                    new Car()
                    {
                        Brand = "Nissan",
                        Model = "1993",
                        CarRegNumber = 21231
                    }
                },
                Managers = new List<Manager>()
                {
                    new Manager()
                    {
                        Name = "Tiza",
                        SallaryPerMonth = 600.32m,
                        Surname = "Zach",
                    }
                },
                Customers =new List<Customer>()
                { 
                    new Customer()
                    {
                        Name="Fotis",
                        Surname="Grammenos",
                        Phone="6969696969",
                        TIN="12345"
                    }
                },
                Engineers =new List<Engineer>() 
                { 
                   new Engineer()
                   {
                       Name="Makis",
                       Surname="Kotsampasis",
                       ManagerID=new Guid(),
                       SallaryPerMonth=100
                   }
                },
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        CarID = new Guid(),
                        CustomerID = new Guid(),
                        ManagerID = new Guid(),
                        TotalPrice =5,
                        Date = DateTime.Now
                    }
                },
                TransactionLines = new List<TransactionLine>()
                {
                    new TransactionLine()
                    {
                        EngineerID = new Guid(),
                        Hours = 5,
                        Price =6,
                        PricePerHour = (decimal)44.5,
                        ServiceTaskID = new Guid(),
                        TransactionID = new Guid()
                    }
                },
                ServiceTasks = new List<ServiceTask>()
                {
                    new ServiceTask()
                    {
                        Code="1234",
                        Description="hello world",
                        Hours=5
                    }
                }
            };
=======
            callTestFunc();
            //{
            //    Cars = new List<Car>()
            //    {
            //        new Car()
            //        {
            //            Brand = "Ford",
            //            Model = "2003",
            //            CarRegNumber = 234321
            //        },
            //        new Car()
            //        {
            //            Brand = "Nissan",
            //            Model = "1993",
            //            CarRegNumber = 21231
            //        }
            //    },
            //    Managers = new List<Manager>()
            //    {
            //        new Manager()
            //        {
            //            Name = "Tiza",
            //            SallaryPerMonth = 600.32m,
            //            Surname = "Zach",
            //        }
            //    }
            //};
>>>>>>> main
        }

        #region UI Controls

        private void CarCenter_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void callTestFunc()
        {
            var manager1 = new Manager()
            {
                Name = "Kostas",
                Surname = "Papadopoulos",
                SallaryPerMonth = 1000.0m
            };

            var manager2 = new Manager()
            {
                Name = "Giannis",
                Surname = "Papadopoulos",
                SallaryPerMonth = 1000.0m
            };

            _carService.Managers.Add(manager1);
            _carService.Managers.Add(manager2);

            var engineer1 = new Engineer()
            {
                Name = "Nikos",
                Surname = "Papadopoulos",
                ManagerID = manager1.ID,
                Status = StatusEnum.Free
            };
            var engineer2 = new Engineer()
            {
                Name = "Babis",
                Surname = "Papadopoulos",
                ManagerID = manager1.ID,
                Status = StatusEnum.Free
            };
            var engineer3 = new Engineer()
            {
                Name = "Alekos",
                Surname = "Papadopoulos",
                ManagerID = manager2.ID,
                Status = StatusEnum.Free
            };

            _carService.Engineers.Add(engineer1);
            _carService.Engineers.Add(engineer2);
            _carService.Engineers.Add(engineer3);

            var managerH = new ManagerHandler();
            managerH.Delete(manager1, _carService.Managers, _carService);
        }

        private void LoadData()
        {
            _carService = _storageHelper.LoadData(FILE_NAME);
        }

        private void SaveData()
        {
            _storageHelper.SaveData(FILE_NAME, _carService);
            _messagesHelper.MessageInfo("File saved successfully");

        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ShowForm(new CarF(_carService));
            /*ShowForm(new TransactionF(_carService,_carService.Transactions[0]));
            ShowForm(new TransactionLineF(_carService, _carService.TransactionLines[0]));
            ShowForm(new ServiceTaskF(_carService, _carService.ServiceTasks[0]));*/
        }

        private void Btnengineer_Click(object sender, EventArgs e)
        {
            ShowForm(new EngineerF(_carService));
        }

        private void Btnmanager_Click(object sender, EventArgs e)
        {
            ShowForm(new ManagerF(_carService));
        }

        private void Btncustomer_Click(object sender, EventArgs e)
        {
            ShowForm(new CustomerF(_carService));
        }
    }
}
