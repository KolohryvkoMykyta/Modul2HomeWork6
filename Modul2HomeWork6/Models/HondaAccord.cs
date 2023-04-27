using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class HondaAccord : SedanBusinessTaxi
    {
        public HondaAccord()
           : base()
        {
            Manufacturer = CarManufacturer.Honda;
            Model = CarModel.Accord;
            FuelConsumption = 8.7m;
            Price = new Random().Next(14000, 17000);
        }
    }
}
