using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int case1 = 0;
            int case2 = 0;
            int case3 = 0;
            int case4 = 0;
            int case5 = 0;
            int case6 = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value >= 0 && value <= 9) 
                { 
                    sum += value * 0.2;
                    case1++; 
                }
                if (value >= 10 && value <= 19) 
                {
                    sum += value * 0.3;
                    case2++; 
                }
                if (value >= 20 && value <= 29)
                { 
                    sum += value * 0.4;
                    case3++;
                }
                if (value >= 30 && value <= 39) 
                { 
                    sum += 50;
                    case4++;
                }
                if (value >= 40 && value <= 50) 
                { 
                    sum += 100;
                    case5++;
                }
                if (value < 0 || value > 50) 
                { 
                    sum = sum / 2; 
                    case6++; 
                }

            }
            Console.WriteLine($"{sum:f2}");
            Console.WriteLine("From 0 to 9: {0:f2}%",(case1 / n * 100));
            Console.WriteLine("From 10 to 19: {0:f2}%",(case2 / n * 100));
            Console.WriteLine("From 20 to 29: {0:f2}%",(case3 / n * 100));
            Console.WriteLine("From 30 to 39: {0:f2}%",(case4 / n * 100));
            Console.WriteLine("From 40 to 50: {0:f2}%",(case5 / n * 100));
            Console.WriteLine("Invalid numbers: {0:f2}%",(case6 / n * 100));
        }
    }
}
