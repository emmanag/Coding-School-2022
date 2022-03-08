using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {
        public Message[] Messages { get; set; }
        

        public Message[] ReadAll()
        {
            return Messages; 
        }

        public void Clear()
        {
            return; 
        }

        public void Write()
        {
            Console.WriteLine(Messages);
        }
    }

    
}
