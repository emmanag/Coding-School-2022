using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    internal class Class1
    {
        public string Reverse(string s)
        {

            char[] cArray = s.ToCharArray(); ;
            string reverse = string.Empty;
            for (int i = cArray.Length - 1; i >= 0; i--)
            {
                reverse += cArray[i];
                
            }
            return reverse;

        }

    }
}
