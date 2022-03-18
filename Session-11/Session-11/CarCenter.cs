using DataLibrary;
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
        }

        #region UI Controls

        private void CarCenter_Load(object sender, EventArgs e)
        {

        }

        #endregion


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
    }
}
