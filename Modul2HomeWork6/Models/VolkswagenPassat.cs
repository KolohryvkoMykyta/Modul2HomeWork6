using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class VolkswagenPassat : StationWagonStandartTaxi
    {
        public VolkswagenPassat()
           : base()
        {
            Manufacturer = CarManufacturer.Volkswagen;
            Model = CarModel.Passat;
            FuelConsumption = 6.3m;
            Price = new Random().Next(4700, 5100);
        }
    }
}
