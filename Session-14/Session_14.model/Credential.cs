using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_14.model
{
    public class Credential : Item
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Credential(string username)
        {
            Username = username;
        }
    }
}
