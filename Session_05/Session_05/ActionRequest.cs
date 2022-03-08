using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    //public enum ActionEnum
    //{
    //    Covert,
    //    Uppercase,
    //    Revere
    //}
    internal class ActionRequest
    {
        public Guid RequestId { get; set; }
        public string Input { get; set; }

        public enum ActionEnum
        {
            Covert,
            Uppercase,
            Revere
        }
        public ActionRequest(Guid requestId, string input, ActionEnum action, ActionEnum actionEnum) 
        { 
            RequestId = requestId;
            Input = input;
            actionEnum = action;
            
        }

    }

    


    
    


        


    
}


