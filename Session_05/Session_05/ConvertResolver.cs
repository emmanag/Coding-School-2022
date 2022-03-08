using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ConvertResolver : AbstractResolverBase
    {
        


        public override string Execute(string content)
        {

            int result;
            if (int.TryParse(content, out result))
            {

                return null;
            }

            return Convert.ToString(result, 2);
        }
        public ConvertResolver()
        { 
        }
    }
}
