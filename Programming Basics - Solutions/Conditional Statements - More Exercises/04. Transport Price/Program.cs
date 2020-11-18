using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string condition = Console.ReadLine();

            double price = 0;
            double taxiRate = 0;

            if (condition == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }

            if (number < 20)
            {
                price = 0.70 + number * taxiRate;
            }
            else if (number < 100)
            {
                price = number * 0.09;
            }
            else
            {
                price = number * 0.06;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
