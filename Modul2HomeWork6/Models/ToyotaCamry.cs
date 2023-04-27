using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class ToyotaCamry : SedanBusinessTaxi
    {
        public ToyotaCamry()
          : base()
        {
            Manufacturer = CarManufacturer.Toyota;
            Model = CarModel.Camry;
            FuelConsumption = 8.1m;
            Price = new Random().Next(17000, 21000);
        }
    }
}
