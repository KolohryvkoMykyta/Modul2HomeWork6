using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class VazSamara : HatchbackEconomyTaxi
    {
        public VazSamara()
            : base()
        {
            Manufacturer = CarManufacturer.VAZ;
            Model = CarModel.Samara;
            FuelConsumption = 7.8m;
            Price = new Random().Next(2300, 2700);
        }
    }
}
