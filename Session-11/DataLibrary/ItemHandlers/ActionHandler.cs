using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ActionHandler
    {
        public ActionHandler()
        {

        }

        public virtual object Create()
        {
            return null;
        }

        public virtual void Delete<T>(T obj, List<T> list)
        {
            list.Remove(obj);
        }
    }
}
