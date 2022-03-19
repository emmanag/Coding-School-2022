using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ItemHandlers
{
    public class CustomerHandler
    {
        public CustomerHandler()
        {

        }

        public Customer Create()
        {
            return new Customer();
        }

        public void Delete(Customer customer, List<Customer> customers)
        {
            customers.Remove(customer);
        }
    }
}
