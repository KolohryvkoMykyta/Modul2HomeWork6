using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class SedanEconomyTaxi : EconomyTaxi
    {
        protected SedanEconomyTaxi()
            : base()
        {
            BodyType = CarBodyType.Sedan;
        }
    }
}
