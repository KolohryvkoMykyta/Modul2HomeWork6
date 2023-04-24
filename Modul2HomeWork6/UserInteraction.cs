using Modul2HomeWork6.Enums;

namespace Modul2HomeWork6
{
    public static class UserInteraction
    {
        public static int ChooseNumberOfTaxi()
        {
            int result;
            bool isCorrectInput;

            Console.Write("Select the number of taxi cars in the taxi depot: ");
            isCorrectInput = int.TryParse(Console.ReadLine(), out result);

            while (!isCorrectInput || result <= 0)
            {
                Console.Write("Incorect input! Please try again: ");
                isCorrectInput = int.TryParse(Console.ReadLine(), out result);
            }

            return result;
        }

        public static FilterType AskForFilterType()
        {
            Console.WriteLine("\nChoose by what criteria to sort the taxi cars: (press 1, 2 or 3)\n1 Sort by Class\n2 Sort by Body Type\n3 Sort by Number\n" +
                "4 Sort by FuelConsumption\n5 Sort by Price");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return FilterType.Class;
                    case '2':
                        return FilterType.BodyType;
                    case '3':
                        return FilterType.Number;
                    case '4':
                        return FilterType.FuelConsumption;
                    case '5':
                        return FilterType.Price;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1, 2 or 3!");
                        break;
                }
            }
        }

        public static TaxiClass AskForTaxiClass()
        {
            Console.WriteLine("\nChoose how to filter taxi cars: (press 1, 2 or 3)\n1 Economy taxi\n2 Standart taxi\n3 Business taxi");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return TaxiClass.Economy;
                    case '2':
                        return TaxiClass.Standard;
                    case '3':
                        return TaxiClass.Business;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1, 2 or 3!");
                        break;
                }
            }
        }

        public static CarBodyType AskForCarBodyType()
        {
            Console.WriteLine("\nChoose how to filter taxi cars: (press 1, 2, 3 or 4)\n1 Sedan\n2 Station Wagon\n3 Crossover\n4 Hatchback");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return CarBodyType.Sedan;
                    case '2':
                        return CarBodyType.StationWagon;
                    case '3':
                        return CarBodyType.Crossover;
                    case '4':
                        return CarBodyType.Hatchback;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1 or 2!");
                        break;
                }
            }
        }

        public static string? AskForTaxiCarNumber()
        {
            Console.Write("\nWrite the number of the car you want to find (example: 'AA0001AX'): ");

            return Console.ReadLine();
        }

        public static (decimal, decimal) AskForFuelConsumption()
        {
            decimal minValue, maxValue;
            bool isCorrectInput;

            Console.Write("\nInput the minimum fuel consumption value: ");
            isCorrectInput = decimal.TryParse(Console.ReadLine(), out minValue);

            while (!isCorrectInput || minValue <= 0)
            {
                Console.Write("Incorect input! Please input number greater than 0: ");
                isCorrectInput = decimal.TryParse(Console.ReadLine(), out minValue);
            }

            Console.Write("\nInput the maximum fuel consumption value: ");
            isCorrectInput = decimal.TryParse(Console.ReadLine(), out maxValue);

            while (!isCorrectInput || maxValue < minValue)
            {
                Console.Write($"Incorect input! Please input number greater than {minValue}: ");
                isCorrectInput = decimal.TryParse(Console.ReadLine(), out maxValue);
            }

            return (minValue, maxValue);
        }

        public static (int, int) AskForPrice()
        {
            int minValue, maxValue;
            bool isCorrectInput;

            Console.Write("\nInput the minimum price value: ");
            isCorrectInput = int.TryParse(Console.ReadLine(), out minValue);

            while (!isCorrectInput || minValue <= 0)
            {
                Console.Write("Incorect input! Please input integer greater than 0: ");
                isCorrectInput = int.TryParse(Console.ReadLine(), out minValue);
            }

            Console.Write("\nInput the maximum price value: ");
            isCorrectInput = int.TryParse(Console.ReadLine(), out maxValue);

            while (!isCorrectInput || maxValue < minValue)
            {
                Console.Write($"Incorect input! Please input integer greater {minValue}: ");
                isCorrectInput = int.TryParse(Console.ReadLine(), out maxValue);
            }

            return (minValue, maxValue);
        }

        public static int AskForActionForEmptyArray()
        {
            Console.WriteLine("\nThere are no taxi cars matching your criteria!");
            Console.WriteLine("Choose what to do next: (press 1, 2 or 3)");
            Console.WriteLine("1 Reset previous filter");
            Console.WriteLine("2 Reset all filters");
            Console.WriteLine("3 Exit");

            while (true)
            {
                char choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        return 0;
                    case '2':
                        return 1;
                    case '3':
                        return 2;
                    default:
                        Console.WriteLine("\nIncorrect input! Press 1, 2 or 3!");
                        break;
                }
            }
        }

        public static bool AskForPrint()
        {
            Console.WriteLine("\nIf you want to see a list of all taxi cars press SPACE button");
            Console.WriteLine("If not press any button");

            char choice = Console.ReadKey(true).KeyChar;

            if (choice == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AskForContinue()
        {
            Console.WriteLine("\nIf you want to continue press SPACE button");
            Console.WriteLine("To exit press any button");

            char choice = Console.ReadKey(true).KeyChar;

            if (choice == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
