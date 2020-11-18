using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                if (value <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum = sum + value;
                Console.WriteLine($"Increase: {value:f2}");
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
