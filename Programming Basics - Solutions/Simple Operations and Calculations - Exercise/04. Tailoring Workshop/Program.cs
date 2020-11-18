using System;

namespace _04._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double usd = number * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double bgn = number * (lenght / 2) * (lenght / 2);

            double usdPrice = usd * 7 + bgn * 9;
            double bgnPrice = usdPrice * 1.85;

            Console.WriteLine($"{usdPrice:F2} USD");
            Console.WriteLine($"{bgnPrice:F2} BGN");
        }
    }
}
