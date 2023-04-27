using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class VAZPriora : SedanEconomyTaxi
    {
        public VAZPriora()
            : base()
        {
            Manufacturer = CarManufacturer.VAZ;
            Model = CarModel.Priora;
            FuelConsumption = 9.3m;
            Price = new Random().Next(3100, 3500);
        }
    }
}
