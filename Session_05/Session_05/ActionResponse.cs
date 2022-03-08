using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResponse
    {
        public  Guid RequestId { get; set; }
        public Guid ResponseId { get; set; }
        public string Output { get; set; }

        public ActionResponse(Guid requestId, Guid responseId, string output)
        {
            RequestId = requestId;
            ResponseId = responseId;
            Output = output;
        }
    }
    
}
