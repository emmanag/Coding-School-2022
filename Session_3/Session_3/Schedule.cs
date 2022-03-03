using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    internal class Schedule
    {
        public Guid Id { get; set; }

        public Guid CourseID { get; set; }

        public Guid Professor { get; set; }

        public DateTime Calendar { get; set; }

        public Schedule()
        {
            Id = Guid.NewGuid();
        }

    }
}
