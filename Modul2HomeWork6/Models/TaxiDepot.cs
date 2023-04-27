using System.Drawing;

namespace Modul2HomeWork6.Models
{
    public class TaxiDepot
    {
        public TaxiDepot(int taxiDepotSize)
        {
            TaxiList = new TaxiCar[taxiDepotSize];

            for (int i = 0; i < TaxiList.Length; i++)
            {
                TaxiList[i] = GetRandomCar();
            }

            Array.Sort(TaxiList);
        }

        public TaxiCar[] TaxiList { get; private set; }

        private TaxiCar GetRandomCar()
        {
            int random = new Random().Next(10);

            return random switch
            {
                0 => new ChevroletAveo(),
                1 => new ChevroletLacetti(),
                2 => new DaewooLanos(),
                3 => new HondaAccord(),
                4 => new SkodaOctavia(),
                5 => new ToyotaCamry(),
                6 => new VAZ2112(),
                7 => new VAZPriora(),
                8 => new VazSamara(),
                _ => new VolkswagenPassat()
            };
        }
    }
}
