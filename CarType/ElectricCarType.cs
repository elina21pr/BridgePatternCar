using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternCar.CarType
{
    public class ElectricCarType : ICarType
    {
        public void GetEngineType()
        {
            Console.WriteLine("Type Engine: electricengine");
        }
        public void GetFuelType()
        {
            Console.WriteLine("Type Fuel: electric ");
        }
    }
}