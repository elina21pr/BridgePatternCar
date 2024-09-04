using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternCar
{
    public abstract class Car
    {
        protected ICarType _carType;
        protected string _engine;
        protected string _fuel;
        protected Car(ICarType carType, string engine, string fuel)
        {
            _carType = carType;
            _engine = engine;
            _fuel = fuel;

        }
        public abstract void  GetEngineType(string engine);
        public abstract void GetFuelType(string fuel);

        public void SetCarType(ICarType carType)
        {
            _carType = carType;
            Console.WriteLine("Car type has type changed");
        }

        public abstract void DisplayCarInfo();

        
    }

    
}
