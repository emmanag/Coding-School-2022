using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ManagerHandler
    {
        public ManagerHandler()
        {

        }

        public Manager Create()
        {
            return new Manager();
        }

        public void Delete(Manager manager, List<Manager> managers, CarService carService)
        {
            carService.Engineers.FindAll(e => e.ManagerID == manager.ID).ForEach(e => { e.ManagerID = null;
                e.Status = StatusEnum.WithoutManager;
            });
            managers.Remove(manager);
        }
    }
}
