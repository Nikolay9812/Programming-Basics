using System;

namespace _01._Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            
            double B = 29.4 * 1.85;
            double C = 3 * x1 + 3 * x2;
            double D = x3 * 0.9;
            double D1 = x3 * 0.85;
            double D2 = x3 * 0.8;
            double totalMoney = B + C + D + D1 + D2;

            Console.WriteLine($"Money needed: {totalMoney:f2}");
        }
    }
}
