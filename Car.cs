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

        protected Car(ICarType carType)
        {
            _carType = carType;


        }
        public abstract void GetEngineType();
        public abstract void GetFuelType();

        public void SetCarType(ICarType carType)
        {
            _carType = carType;
            Console.WriteLine("Car type has type changed");
        }

        public abstract void DisplayCarInfo();


    }


}