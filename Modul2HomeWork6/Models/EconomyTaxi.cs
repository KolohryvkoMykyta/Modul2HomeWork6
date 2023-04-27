using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class EconomyTaxi : TaxiCar
    {
        protected EconomyTaxi()
            : base()
        {
            Class = TaxiClass.Economy;
        }
    }
}
