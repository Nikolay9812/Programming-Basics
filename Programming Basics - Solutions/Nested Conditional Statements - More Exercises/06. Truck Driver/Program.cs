using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {            
            string season = Console.ReadLine();
            double mountKilometres = double.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (mountKilometres <= 5000)
                {
                    price = mountKilometres * 0.75;
                }else if (mountKilometres > 5000 && mountKilometres <= 10000)
                {
                    price = mountKilometres * 0.95;
                }else if ( mountKilometres > 10000 && mountKilometres <= 20000)
                {
                    price = mountKilometres * 1.45;
                }
            }else if (season == "Summer")
            {
                if (mountKilometres <= 5000)
                {
                    price = mountKilometres * 0.90;
                }
                else if (mountKilometres > 5000 && mountKilometres <= 10000)
                {
                    price = mountKilometres * 1.10;
                }
                else if (mountKilometres > 10000 && mountKilometres <= 20000)
                {
                    price = mountKilometres * 1.45;
                }
            }else if (season == "Winter")
            {
                if (mountKilometres <= 5000)
                {
                    price = mountKilometres * 1.05;
                }
                else if (mountKilometres > 5000 && mountKilometres <= 10000)
                {
                    price = mountKilometres * 1.25;
                }
                else if (mountKilometres > 10000 && mountKilometres <= 20000)
                {
                    price = mountKilometres * 1.45;
                }
            }

            double discount = 4 * price;
            discount -= discount * 0.1;

            Console.WriteLine($"{discount:f2}");
        }
    }
}
