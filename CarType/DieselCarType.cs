using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternCar.CarType
{
    public class DieselCarType : ICarType
    {
        public void GetEngineType()
        {
            Console.WriteLine("Type Engine: dieselengine ");
        }
        public void GetFuelType()
        {
            Console.WriteLine("Type Fuel: diesel ");
        }
    }
}
