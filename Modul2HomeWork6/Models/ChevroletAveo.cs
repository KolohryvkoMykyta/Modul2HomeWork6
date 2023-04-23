using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class ChevroletAveo : SedanStandartTaxi
    {
        public ChevroletAveo()
            : base()
        {
            Manufacturer = CarManufacturer.Chevrolet;
            Model = CarModel.Aveo;
            FuelConsumption = 9.0m;
            Price = new Random().Next(3800, 4200);
        }
    }
}
