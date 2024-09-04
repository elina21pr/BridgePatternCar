using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternCar.CarType
{
    public class PetrolCarType : ICarType
    {
        public void GetEngineType(string engine)
        {
            Console.WriteLine("Type Engine: " + engine);
        }
        public void GetFuelType(string fuel)
        {
            Console.WriteLine("Type Fuel: " + fuel);
        }
    }
}
