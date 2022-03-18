using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ServiceTaskHandler
    {
        public ServiceTaskHandler()
        {

        }

        public ServiceTask Create()
        {
            return new ServiceTask();
        }

        public void Delete(ServiceTask serviceTask, List<ServiceTask> serviceTasks)
        {
            serviceTasks.Remove(serviceTask);
        }
    }
}
