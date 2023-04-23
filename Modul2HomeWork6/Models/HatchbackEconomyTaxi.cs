using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class HatchbackEconomyTaxi : EconomyTaxi
    {
        protected HatchbackEconomyTaxi()
            : base()
        {
            BodyType = CarBodyType.Hatchback;
        }
    }
}
