using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                sum += value / n ;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
