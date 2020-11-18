using System;

namespace _06._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value <= min)
                {
                    min = value;
                }
            }
            Console.WriteLine(min);
        }
    }
}