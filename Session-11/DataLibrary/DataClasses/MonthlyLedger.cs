using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public enum Month {
        January,
        February, 
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    };

    public class MonthlyLedger : Item
    {
        public int Year { get; set; }

        public Month Month { get; set; }

        public decimal Income { get; set; }

        public decimal Expenses { get; set; }

        public decimal Total { get; set; }

        public MonthlyLedger()
        {

        }

    }
}
