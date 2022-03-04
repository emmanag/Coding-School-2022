using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    internal class Class2
    {


        public int GetSum(int x)
        {
            int sum = 0;

            for (int i = 0; i < x; i++)
            {
                sum = sum + i;
            }


            return sum;
        }

        public int GetProduct(int x)
        {
            int prod = 1;

            for (int i = 0; i < x; i++)
            {
                prod = prod * i;
            }


            return prod;
        }

        public Class2()
        {
        }




    }
}
