using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.Model
{
    public class BaseEntity
    {
        public Guid ID { get; set; }

        public BaseEntity()
        {
            ID = Guid.NewGuid();
        }
    }
}
