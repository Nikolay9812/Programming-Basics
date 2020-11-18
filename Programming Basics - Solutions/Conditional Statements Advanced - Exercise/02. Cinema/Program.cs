using System;

namespace _02._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double sum = 0;

            if (projectionType == "Premiere")
            {
                sum = rows * columns * 12.00;
            }else if (projectionType == "Normal")
            {
                sum = rows * columns * 7.50;
            }else if (projectionType == "Discount")
            {
                sum = rows * columns * 5.00;
            }

            Console.WriteLine($"{sum:f2} leva");
        }
    }
}
