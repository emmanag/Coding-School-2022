using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ItemHandlers
{
    public class CustomerHandler : ActionHandler
    {
        public CustomerHandler()
        {

        }

        public override object Create()
        {
            return new Customer();
        }

        public override void Delete<Customer>(Customer customer, List<Customer> customers)
        {
            customers.Remove(customer);
        }
    }
}
