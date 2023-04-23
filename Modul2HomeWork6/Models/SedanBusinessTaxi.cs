using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public class SedanBusinessTaxi : BusinessTaxi
    {
        protected SedanBusinessTaxi()
            : base()
        {
            BodyType = CarBodyType.Sedan;
        }
    }
}
