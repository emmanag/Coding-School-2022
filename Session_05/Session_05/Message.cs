using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {
        public Guid Id { get; set; }        
        public DateTime TimeStamp { get; set; }

        public string _Message { get; set; }

        public Message() 
        {
            Id = Guid.NewGuid();
        }
            
    }
}
