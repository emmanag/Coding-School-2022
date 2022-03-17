using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ManagerHandler : ActionHandler
    {
        public ManagerHandler()
        {

        }

        public override object Create()
        {
            return new Manager();
        }

        public override void Delete<Manager>(Manager obj, List<Manager> list)
        {
            list.Remove(obj);
        }
    }
}
