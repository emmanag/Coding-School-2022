using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class CarHandler : ActionHandler
    {
        public CarHandler()
        {

        }

        public override object Create()
        {
            return new Car();
        }

        public override void Delete<Car>(Car car, List<Car> cars)
        {
            cars.Remove(car);
        }
    }
}
