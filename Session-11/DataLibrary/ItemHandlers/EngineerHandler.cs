using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    internal class EngineerHandler : ActionHandler
    {
        public EngineerHandler()
        {

        }

        public override object Create()
        {
            return new Engineer();
        }

        public override void Delete<Engineer>(Engineer obj, List<Engineer> list)
        {
            list.Remove(obj);
        }
 
    }
}
