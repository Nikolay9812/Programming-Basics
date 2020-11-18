using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetOfTheGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());

            double seasonPrice = 0;

            if (season == "Spring")
            {
                seasonPrice = 3000;
            }
            else if (season == "Summer")
            {
                seasonPrice = 4200;
            }
            else if (season == "Autumn")
            {
                seasonPrice = 4200;
            }
            else if (season == "Winter")
            {
                seasonPrice = 2600;
            }

            if (numberOfFishermen <= 6)
            {
                seasonPrice -= seasonPrice * 0.1;
            }
            else if (numberOfFishermen >= 7 && numberOfFishermen <= 11)
            {
                seasonPrice -= seasonPrice * 0.15;
            }
            else if (numberOfFishermen > 12)
            {
                seasonPrice -= seasonPrice * 0.25;
            }

            if (season != "Autumn" && numberOfFishermen % 2 == 0)
            {
                seasonPrice -= seasonPrice * 0.05;
            }

            if (budgetOfTheGroup < seasonPrice)
            {
                double neededMoney = seasonPrice - budgetOfTheGroup;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }else if (budgetOfTheGroup >= seasonPrice)
            {
                double leftMoney = budgetOfTheGroup - seasonPrice;
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
        }
    }
}
