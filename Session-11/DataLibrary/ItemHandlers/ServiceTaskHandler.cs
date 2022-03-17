using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ServiceTaskHandler : ActionHandler
    {
        public ServiceTaskHandler()
        {

        }

        public override object Create()
        {
            return new ServiceTask();
        }

        public override void Delete<ServiceTask>(ServiceTask serviceTask, List<ServiceTask> serviceTasks)
        {
            serviceTasks.Remove(serviceTask);
        }
    }
}
