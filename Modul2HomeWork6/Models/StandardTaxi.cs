using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class StandardTaxi : TaxiCar
    {
        protected StandardTaxi()
            : base()
        {
            Class = TaxiClass.Standard;
        }
    }
}
