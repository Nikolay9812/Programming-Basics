using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value >= max)
                {
                    max = value;
                }
            }
            Console.WriteLine(max);
        }
    }
}
