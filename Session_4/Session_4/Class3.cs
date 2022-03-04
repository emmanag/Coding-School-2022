using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    internal class Class3
    {
        public void Prime(int a)
        {

            for (int i = 2; i <= a; i++)
            {
                bool prime1 = true;
                for (int j = 2; j < a / 2; j++)
                {
                    if (i != j)
                    {
                        if (i % j == 0)
                        {
                            prime1 = false;
                        }

                    }

                }

                if (prime1)
                {
                    Console.Write($"{i} ");
                }

            }
            Console.WriteLine();
        }
        public Class3()
        {

        }
    }
}
