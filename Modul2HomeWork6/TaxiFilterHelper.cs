using Modul2HomeWork6.Enums;
using Modul2HomeWork6.Models;

namespace Modul2HomeWork6
{
    public class TaxiFilterHelper
    {
        private TaxiCar[] _taxiCars;
        private TaxiCar[] _previousTaxiCars;
        private TaxiCar[] _initialTaxiCars;

        public TaxiFilterHelper(TaxiCar[] cars)
        {
            _taxiCars = cars;
            _previousTaxiCars = cars;
            _initialTaxiCars = cars;
        }

        public void FilterTaxiCarsByUserRequirements()
        {
            var @continue = true;
            bool isPrinted = false;

            while (@continue)
            {
                isPrinted = false;
                _previousTaxiCars = _taxiCars;
                _taxiCars = Filter();

                PrintCount();
                Console.WriteLine($"Total price of selected taxi cars: ${_taxiCars.CountTotalPrice()}");

                if (_taxiCars.Length < 1)
                {
                    if (HandleEmptyArray())
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                var needToPrint = UserInteraction.AskForPrint();

                if (needToPrint)
                {
                    PrintTaxiCars();
                    isPrinted = true;
                }

                @continue = UserInteraction.AskForContinue();
            }

            if (!isPrinted)
            {
                PrintTaxiCars();
            }
        }

        private void PrintCount()
        {
            Console.WriteLine($"\nFound {_taxiCars.Count()} taxi cars in taxi depot");
        }

        private bool HandleEmptyArray()
        {
            var actionForEmptyArray = UserInteraction.AskForActionForEmptyArray();

            switch (actionForEmptyArray)
            {
                case 0:
                    _taxiCars = _previousTaxiCars;
                    return true;
                case 1:
                    _taxiCars = _initialTaxiCars;
                    return true;
                default:
                    return false;
            }
        }

        private TaxiCar[] Filter()
        {
            var filterType = UserInteraction.AskForFilterType();

            return filterType switch
            {
                FilterType.Class => FilterByTaxiClass(),
                FilterType.BodyType => FilterByTaxiCarBodyType(),
                FilterType.Number => FilterByTaxiCarNumber(),
                _ => new TaxiCar[0]
            };
        }

        private TaxiCar[] FilterByTaxiClass()
        {
            var taxiClass = UserInteraction.AskForTaxiClass();

            return _taxiCars.FilterTaxi(taxiClass);
        }

        private TaxiCar[] FilterByTaxiCarBodyType()
        {
            var bodyType = UserInteraction.AskForCarBodyType();

            return _taxiCars.FilterTaxi(bodyType);
        }

        private TaxiCar[] FilterByTaxiCarNumber()
        {
            var number = UserInteraction.AskForTaxiCarNumber();

            return _taxiCars.FilterTaxi(number);
        }

        private void PrintTaxiCars()
        {
            foreach (var car in _taxiCars)
            {
                car.Print();
            }
        }
    }
}
