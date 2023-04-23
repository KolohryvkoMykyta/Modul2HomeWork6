using System.Text;

namespace Modul2HomeWork6.Models
{
    public class CarNumber
    {
        private static string[] _regionCode = new string[]
        {
            "AA", "Ka", "AI", "KI", "AB", "KB", "AC", "KC", "AE", "KE", "AH", "KH", "AM", "KM", "AO", "KO", "AP", "KP", "AT", "KT", "BA", "HA", "BB", "HB", "BC", "HC", "CH",
            "BE", "HE", "BH", "HH", "BI", "HI", "BK", "HK", "BM", "HM", "BO", "HO", "AX", "KX", "BT", "HT", "BX", "HX", "CA", "IA", "CB", "IB", "CE", "IE", "AK", "KK", "IH"
        };

        private static string _allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public CarNumber()
        {
            Number = GetRandomNumber();
        }

        public string Number { get; init; }

        private string GetRandomNumber()
        {
            var result = new StringBuilder();
            var random = new Random();

            result.Append(_regionCode[random.Next(_regionCode.Length)]);
            result.Append(random.Next(10));
            result.Append(random.Next(10));
            result.Append(random.Next(10));
            result.Append(random.Next(10));
            result.Append(_allChars[random.Next(_allChars.Length)]);
            result.Append(_allChars[random.Next(_allChars.Length)]);

            return result.ToString();
        }
    }
}
