using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class TaxiCar : IComparable
    {
        protected TaxiCar()
        {
            Number = new CarNumber();
        }

        public CarNumber Number { get; private set; }
        public decimal FuelConsumption { get; protected set; }
        public CarBodyType BodyType { get; protected set; }
        public CarManufacturer Manufacturer { get; protected set; }
        public CarModel Model { get; protected set; }
        public TaxiClass Class { get; protected set; }
        public int Price { get; protected set; }

        public int CompareTo(object? obj)
        {
            return FuelConsumption.CompareTo(((TaxiCar)obj).FuelConsumption);
        }

        public void Print()
        {
            Console.WriteLine($"\nNumber: {Number.Number}, Model: {Manufacturer} {Model}, Type: {BodyType},\n" +
                $" Class: {Class}, Price: {Price}$, Fuel Consumption: {FuelConsumption} L/100km");
        }
    }
}
