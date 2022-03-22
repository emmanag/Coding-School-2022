using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_14.model
{
    public class MonthlyLedger
    {
        public int Year { get { return DateTimeValue.Year; } }

        public int Month { get { return DateTimeValue.Month; } }

        public DateTime DateTimeValue { get; set; }

        public decimal Income { get; set; }

        public decimal Expenses { get; set; }

        public decimal Total { get; set; }

        public MonthlyLedger()
        {

        }

    }
}
