using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver(MessageLogger logger)
        {
            Logger = logger;
        }

        private AbstractResolverBase(ActionEnum action)
        {
            switch (action)
            {
                case ActionEnum.Convert:                    
                    return new ConvertResolver();
                    break;
                case ActionEnum.Uppercase:                   
                    return new UppercaseResolver();
                    break;
                case ActionEnum.Reverse:                    
                    return new ReverseResolver();
                    break;
                default:                  
                    return null;
                    break;
            }
        }
        
               
    }

}


//switch (Action)
//{
//    case ActionEnum.Convert:
//        return new ConverResolver();
//        break;
//}





