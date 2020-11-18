using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeOfVacation = "";
            double spendMoney = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    destination = "Bulgaria";
                    typeOfVacation = "Camp";
                    spendMoney = budget * 0.3;
                }
                else if (season == "winter")
                {
                    destination = "Bulgaria";
                    typeOfVacation = "Hotel";
                    spendMoney = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    destination = "Balkans";
                    typeOfVacation = "Camp";
                    spendMoney = budget * 0.4;
                }
                else if (season == "winter")
                {
                    destination = "Balkans";
                    typeOfVacation = "Hotel";
                    spendMoney = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfVacation = "Hotel";
                spendMoney = budget * 0.9;
            }


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {spendMoney:f2}");
        }
    }
}
