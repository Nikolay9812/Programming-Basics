using System;

namespace _05._Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double sum = 0;
            int counter = 0;

            while (command != "The restaurant is full")
            {
                int value = int.Parse(command);
                if (value < 5)
                {
                    sum += value * 100;
                }
                if (value >= 5)
                {
                    sum += value * 70;
                }
                command = Console.ReadLine();
                counter += value;
            }
            if (n <= sum)
            {
                Console.WriteLine($"You have {counter} guests and {sum - n} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {counter} guests and {sum} leva income, but no singer.");
            }
            
            
        }
    }
}
