using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());

            double A = x1 * 0.3;
            double B = x1 - (x3 + A);
            double C = x2 * B;
            double procent = B / x1 * 100;

            Console.WriteLine($"She can save {procent:f2}%");
            Console.WriteLine($"{C:f2}");

        }
    }
}
