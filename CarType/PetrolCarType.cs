using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternCar.CarType
{
    public class PetrolCarType : ICarType
    {
        public void GetEngineType()
        {
            Console.WriteLine("Type Engine: petrolengine ");
        }
        public void GetFuelType()
        {
            Console.WriteLine("Type Fuel: petrol");
        }
    }
}