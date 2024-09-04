using System;

namespace BridgePatternCar
{
    public class Sedan : Car
    {
        public Sedan(ICarType carType, string engine, string fuel)
            : base(carType, engine, fuel) 
        {
        }
 
        public override void GetEngineType(string engine)
        {
            Console.WriteLine($"Sedan has engine type: {engine}");
        }

        public override void GetFuelType(string fuel)
        {
            Console.WriteLine($"Sedan uses fuel type: {fuel}");
        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine("Information about Sedan:");
            
            _carType.GetEngineType(_engine);
            _carType.GetFuelType(_fuel);
        }
    }
}
