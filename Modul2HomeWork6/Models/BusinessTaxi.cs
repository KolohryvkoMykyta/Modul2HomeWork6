using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class BusinessTaxi : TaxiCar
    {
        protected BusinessTaxi()
            : base()
        {
            Class = TaxiClass.Business;
        }
    }
}
