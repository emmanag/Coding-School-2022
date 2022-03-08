using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public abstract class AbstractResolverBase
    {
        

        public abstract string Execute(string content);

        public AbstractResolverBase()
        {
        }
    }
}
