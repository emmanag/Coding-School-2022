using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    internal class Class4
    {
        public void ArrayNew(int[] Array1, int[] Array2)
        {
           

            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    Console.WriteLine(Array1[i] * Array2[j]);
                    
                }
                
                 
                
            }
            
        }
        public Class4() 
        {
        }
    }

    
}    
