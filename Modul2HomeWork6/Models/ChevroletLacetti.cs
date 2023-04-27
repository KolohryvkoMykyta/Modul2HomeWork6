using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class ChevroletLacetti : StationWagonStandartTaxi
    {
        public ChevroletLacetti()
           : base()
        {
            Manufacturer = CarManufacturer.Chevrolet;
            Model = CarModel.Lacetti;
            FuelConsumption = 8.3m;
            Price = new Random().Next(4100, 4500);
        }
    }
}
