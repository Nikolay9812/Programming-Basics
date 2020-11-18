using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string place = "";

            if (season == "Summer")
            {
                if (budget <= 1000)
                {
                    location = "Alaska";
                    place = "Camp";
                    budget = budget * 0.65;
                    
                }else if (budget > 1000 && budget <= 3000)
                {
                    location = "Alaska";
                    place = "Hut";
                    budget = budget * 0.8;
                }else if (budget > 3000)
                {
                    location = "Alaska";
                    place = "Hotel";
                    budget = budget * 0.9;
                }
            }else if (season == "Winter")
            {
                if (budget <= 1000)
                {
                    location = "Morocco";
                    place = "Camp";
                    budget = budget * 0.45;

                }
                else if (budget > 1000 && budget <= 3000)
                {
                    location = "Morocco";
                    place = "Hut";
                    budget = budget * 0.6;
                }
                else if (budget > 3000)
                {
                    location = "Morocco";
                    place = "Hotel";
                    budget = budget * 0.9;
                }
            }

            Console.WriteLine($"{location} - {place} - {budget:f2}");
        }
    }
}
