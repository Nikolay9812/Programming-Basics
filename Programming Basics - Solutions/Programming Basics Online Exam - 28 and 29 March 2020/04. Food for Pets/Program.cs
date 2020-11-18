using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sumTotal = 0;
            double bonus = 0;

            for (int i = 1; i <= n1; i++)
            {
                int value1 = int.Parse(Console.ReadLine());
                int value2 = int.Parse(Console.ReadLine());
                sum1 += value1;
                sum2 += value2;
                sumTotal += value1 + value2;
                if (i % 3 == 0)
                {
                    bonus += 0.1 * (value1 + value2);
                }

            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(bonus)}gr.");
            Console.WriteLine($"{sumTotal/n2*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{sum1/sumTotal*100:f2}% eaten from the dog.");
            Console.WriteLine($"{sum2/sumTotal*100:f2}% eaten from the cat.");
        }
    }
}
