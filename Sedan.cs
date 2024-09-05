using System;

namespace BridgePatternCar
{
    public class Sedan : Car
    {
        public Sedan(ICarType carType)
            : base(carType)
        {
        }

        public override void GetEngineType()
        {
            Console.WriteLine($"Sedan has engine type: ...");
        }

        public override void GetFuelType()
        {
            Console.WriteLine($"Sedan uses fuel type: ...");
        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine("Information about Sedan:");

            _carType.GetEngineType();
            _carType.GetFuelType();
        }
    }
}