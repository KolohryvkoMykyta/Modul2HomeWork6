using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class SkodaOctavia : SedanStandartTaxi
    {
        public SkodaOctavia()
           : base()
        {
            Manufacturer = CarManufacturer.Skoda;
            Model = CarModel.Octavia;
            FuelConsumption = 6.4m;
            Price = new Random().Next(6000, 6800);
        }
    }
}
