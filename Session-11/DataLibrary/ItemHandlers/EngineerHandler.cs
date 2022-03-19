using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class EngineerHandler
    {
        public EngineerHandler()
        {

        }

        public Engineer Create()
        {
            return new Engineer();
        }

        public void Delete(Engineer engineer, List<Engineer> engineers)
        {
            engineers.Remove(engineer);
        }
 
    }
}
