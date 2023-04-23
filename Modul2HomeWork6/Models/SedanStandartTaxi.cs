using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class SedanStandartTaxi : StandardTaxi
    {
        protected SedanStandartTaxi()
            : base()
        {
            BodyType = CarBodyType.Sedan;
        }
    }
}
