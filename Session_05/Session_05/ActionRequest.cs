using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    
    internal class ActionRequest
    {
        public Guid RequestId { get;}
        public string Input { get; }
        public ActionEnum Action { get; }

        public enum ActionEnum
        {
            Covert,
            Uppercase,
            Revere
        }
        public ActionRequest(Guid requestId, string input, ActionEnum action) 
        { 
            RequestId = requestId;
            Input = input;
            Action= action;
            
        }

    }

    


    
    


        


    
}


