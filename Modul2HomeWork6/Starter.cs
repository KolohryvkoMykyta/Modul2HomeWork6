using Modul2HomeWork6.Models;

namespace Modul2HomeWork6
{
    public static class Starter
    {
        public static void Run()
        {
            var taxiDepot = new TaxiDepot(UserInteraction.ChooseNumberOfTaxi());

            Console.WriteLine($"\nThere are {taxiDepot.TaxiList.Length} cars in your taxi depot");
            Console.WriteLine($"Total cost of all cars ${taxiDepot.TaxiList.CountTotalPrice()}");

            var taxiFilterHelper = new TaxiFilterHelper(taxiDepot.TaxiList);
            taxiFilterHelper.FilterTaxiCarsByUserRequirements();
        }
    }
}
