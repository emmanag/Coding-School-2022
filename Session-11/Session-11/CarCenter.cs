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

namespace Session_11
{
    public partial class CarCenter : Form
    {
        private const string FILE_NAME = "storage.json";
        private CarService _carService;

        public CarCenter()
        {
            InitializeComponent();
            _carService = new CarService();
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
        }

        #region UI Controls

        private void CarCenter_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        #endregion


        private void LoadData()
        {
            try
            {
                string obj = File.ReadAllText(FILE_NAME);
                _carService = JsonConvert.DeserializeObject<CarService>(obj);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem loading data!", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            if (!File.Exists(FILE_NAME))
            {
                File.Create(FILE_NAME);
                File.WriteAllText(FILE_NAME, "{}");
            }

            string jsonObject = JsonConvert.SerializeObject(_carService, Formatting.Indented);
            File.WriteAllText(FILE_NAME, jsonObject);
            MessageBox.Show("File saved successfully.", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
