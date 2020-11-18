using System;

namespace _04._Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            int x2 = int.Parse(Console.ReadLine());
            double sumA = 0;
            double sumB = 0;
            double sumC = 0;
            int A = 0;
            int B = 0;
            int C = 0;

            for (int i = 0; i < x2; i++)
            {
                string x3 = Console.ReadLine();
                int x4 = int.Parse(Console.ReadLine());
                if (x3 == "volleyball")
                {
                    sumA += (0.07 * x4) + x4;
                    A++;
                }
                else if (x3 == "tennis")
                {
                    sumB += (0.05 * x4) + x4;
                    B++;
                }
                else if (x3 == "badminton")
                {
                    sumC += (0.02 * x4) + x4;
                    C++;
                }
            }
            if (sumA / A >= 75 && sumB / B >= 75 && sumC / C >= 75)
            {
                Console.WriteLine($"Congratulations, {x1}! You won the cruise games with {Math.Floor(sumA+sumB+sumC)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {x1}, you lost. Your points are only {Math.Floor(sumA + sumB + sumC)}.");
            }
        }
    }
}
