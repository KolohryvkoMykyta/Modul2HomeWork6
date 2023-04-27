using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public abstract class StationWagonStandartTaxi : StandardTaxi
    {
        protected StationWagonStandartTaxi()
           : base()
        {
            BodyType = CarBodyType.StationWagon;
        }
    }
}
