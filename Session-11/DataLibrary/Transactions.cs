﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Transactions : Item
    {
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public decimal TotalPrice { get; set; }

        public Transactions()
        {

        }
    }
}
