using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;
using Newtonsoft.Json;


namespace Session_11.HelperFunctions
{
    internal class StorageHelper
    {
        private MessagesHelper _messagesHelper;

        public StorageHelper()
        {
            _messagesHelper = new MessagesHelper();
        }

        public CarService LoadData(string filename)
        {
            try
            {
                string obj = File.ReadAllText(filename);
                return JsonConvert.DeserializeObject<CarService>(obj);
            }
            catch (Exception)
            {
                _messagesHelper.MessageError("There was an error with data loading!");
                return null;
            }
        }

        public void SaveData(string filename, CarService carService)
        {
            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, "{}");
            }

            string jsonObject = JsonConvert.SerializeObject(carService, Formatting.Indented);
            File.WriteAllText(filename, jsonObject);
        }
    }
}
