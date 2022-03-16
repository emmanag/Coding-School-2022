using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    internal class Item
    {
        public Guid ID { get; set; }

        public Item()
        {
            ID = Guid.NewGuid();
        }
    }
}
