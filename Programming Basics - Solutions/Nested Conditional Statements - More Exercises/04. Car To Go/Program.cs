using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass = "";
            string car = "";

            if (season == "Summer")
            {
                if (budget <= 100)
                {
                    carClass = "Economy class";
                    car = "Cabrio";
                    budget = budget * 0.35;
                }
                else if (budget > 100 && budget <= 500)
                {
                    carClass = "Compact class";
                    car = "Cabrio";
                    budget = budget * 0.45;
                }
                else if (budget > 500)
                {
                    carClass = "Luxury class";
                    car = "Jeep";
                    budget = budget * 0.9;
                }
            }
            else if (season == "Winter")
            {
                if (budget <= 100)
                {
                    carClass = "Economy class";
                    car = "Jeep";
                    budget = budget * 0.65;
                }
                else if (budget > 100 && budget <= 500)
                {
                    carClass = "Compact class";
                    car = "Jeep";
                    budget = budget * 0.8;
                }
                else if (budget > 500)
                {
                    carClass = "Luxury class";
                    car = "Jeep";
                    budget = budget * 0.9;
                }
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{car} - {budget:f2}");
        }
    }
}