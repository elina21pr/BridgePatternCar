
using BridgePatternCar;
using BridgePatternCar.CarType;

public class Program
{
    static void Main(string[] args)
    {
        ICarType electrickalCarType = new ElectricCarType();
        Car mycar = new Sedan(electrickalCarType, "ElecticEngine", "electrics");
        mycar.DisplayCarInfo();

        ICarType dieselCarType = new DieselCarType();
        mycar.SetCarType(dieselCarType);
        mycar.DisplayCarInfo();

        ICarType petrolCarType = new PetrolCarType();
        mycar.SetCarType(petrolCarType);
        mycar.DisplayCarInfo();

    }
}