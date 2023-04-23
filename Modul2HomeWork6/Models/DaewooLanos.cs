using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class DaewooLanos : SedanEconomyTaxi
    {
        public DaewooLanos()
            : base()
        {
            Manufacturer = CarManufacturer.Daewoo;
            Model = CarModel.Lanos;
            FuelConsumption = 8.9m;
            Price = new Random().Next(2600, 3000);
        }
    }
}
