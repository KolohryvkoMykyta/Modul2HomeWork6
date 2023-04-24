using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6.Models
{
    public static class Extension
    {
        public static int GetTaxiCount(this TaxiCar[] cars, TaxiClass @class)
        {
            int counter = 0;

            foreach (var car in cars)
            {
                if (car.Class == @class)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int GetTaxiCount(this TaxiCar[] cars, string? carNunber)
        {
            int counter = 0;

            foreach (var car in cars)
            {
                if (car.Number.Number == carNunber)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int GetTaxiCount(this TaxiCar[] cars, CarBodyType type)
        {
            int counter = 0;

            foreach (var car in cars)
            {
                if (car.BodyType == type)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int GetTaxiCount(this TaxiCar[] cars, decimal minValue, decimal maxValue)
        {
            int counter = 0;

            foreach (var car in cars)
            {
                if (car.FuelConsumption >= minValue && car.FuelConsumption <= maxValue)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int GetTaxiCount(this TaxiCar[] cars, int minValue, int maxValue)
        {
            int counter = 0;

            foreach (var car in cars)
            {
                if (car.Price >= minValue && car.Price <= maxValue)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static TaxiCar[] FilterTaxi(this TaxiCar[] cars, CarBodyType type)
        {
            TaxiCar[] result = new TaxiCar[cars.GetTaxiCount(type)];
            var counter = 0;

            foreach (var car in cars)
            {
                if (car.BodyType == type)
                {
                    result[counter] = car;
                    counter++;
                }
            }

            return result;
        }

        public static TaxiCar[] FilterTaxi(this TaxiCar[] cars, TaxiClass @class)
        {
            TaxiCar[] result = new TaxiCar[cars.GetTaxiCount(@class)];
            var counter = 0;

            foreach (var car in cars)
            {
                if (car.Class == @class)
                {
                    result[counter] = car;
                    counter++;
                }
            }

            return result;
        }

        public static TaxiCar[] FilterTaxi(this TaxiCar[] cars, string? carNunber)
        {
            TaxiCar[] result = new TaxiCar[cars.GetTaxiCount(carNunber)];
            var counter = 0;

            foreach (var car in cars)
            {
                if (car.Number.Number == carNunber)
                {
                    result[counter] = car;
                    counter++;
                }
            }

            return result;
        }

        public static TaxiCar[] FilterTaxi(this TaxiCar[] cars, decimal minValue, decimal maxValue)
        {
            TaxiCar[] result = new TaxiCar[cars.GetTaxiCount(minValue, maxValue)];
            var counter = 0;

            foreach (var car in cars)
            {
                if (car.FuelConsumption >= minValue && car.FuelConsumption <= maxValue)
                {
                    result[counter] = car;
                    counter++;
                }
            }

            return result;
        }

        public static TaxiCar[] FilterTaxi(this TaxiCar[] cars, int minValue, int maxValue)
        {
            TaxiCar[] result = new TaxiCar[cars.GetTaxiCount(minValue, maxValue)];
            var counter = 0;

            foreach (var car in cars)
            {
                if (car.Price >= minValue && car.Price <= maxValue)
                {
                    result[counter] = car;
                    counter++;
                }
            }

            return result;
        }

        public static int CountTotalPrice(this TaxiCar[] cars)
        {
            int result = 0;

            foreach (var car in cars)
            {
                result += car.Price;
            }

            return result;
        }
    }
}
