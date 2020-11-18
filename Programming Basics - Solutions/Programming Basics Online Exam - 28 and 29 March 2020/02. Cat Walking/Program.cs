using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double A = n1 * n2;
            double B = A * 5;
            double C = n3 * 0.5;

            if (B >= C)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {B}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {B}.");
            }
        }
    }
}
