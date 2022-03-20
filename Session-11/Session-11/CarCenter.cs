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
using DataLibrary.ItemHandlers;
using DevExpress.LookAndFeel;
using DevExpress.Utils;

namespace Session_11
{
    public partial class CarCenter : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;
        private StorageHelper _storageHelper;
        private MessagesHelper _messagesHelper;
        private MonthlyLedgerHandler _monthlyLedgerHandler;

        public CarCenter()
        {
            InitializeComponent();

            // Set Default Theme
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019DarkGray);
            
            _storageHelper = new StorageHelper();
            _messagesHelper = new MessagesHelper();
            _monthlyLedgerHandler = new MonthlyLedgerHandler();
            _carService = new CarService();
        }

        #region UI Controls

        private void CarCenter_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _carService = _storageHelper.LoadData(FILE_NAME);
        }

        private void buttonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _storageHelper.SaveData(FILE_NAME, _carService);
            _messagesHelper.MessageInfo("File saved successfully");
        }

        private void buttonTransShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new TransactionsF(_carService));
        }
        private void buttonManagers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ManagersF(_carService));
        }
        private void buttonServiceTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ServiceTasksF(_carService));
        }

        private void buttonCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new CustomersF(_carService));
        }

        private void buttonEngineers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new EngineersF(_carService));
        }

        private void buttonCars_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new CarsF(_carService));
        }

        private void buttonLedgersShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new MonthlyLedgersF(_carService));
        }

        #endregion


        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void buttonLedgersCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _monthlyLedgerHandler.CreateMonthlyLedger(_carService);
        }
    }
}
