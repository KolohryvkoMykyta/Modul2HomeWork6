using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class VAZ2112 : HatchbackEconomyTaxi
    {
        public VAZ2112()
            : base()
        {
            Manufacturer = CarManufacturer.VAZ;
            Model = CarModel._2112;
            FuelConsumption = 8.5m;
            Price = new Random().Next(2900, 3300);
        }
    }
}
