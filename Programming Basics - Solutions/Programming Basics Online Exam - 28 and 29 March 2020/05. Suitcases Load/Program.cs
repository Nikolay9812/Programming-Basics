using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter1 = 0;
            int counter2 = 0;
            double sum = 0;

            while (command != "End")
            {
                double value = double.Parse(Console.ReadLine());
                counter1++;
                if (counter1 % 3 == 0)
                {
                    n -= value * 0.1;
                }
                else
                {
                    counter2++;
                    n -= value;
                }
                if (value > n)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine("Statistic: {брой натоварени багажи} suitcases loaded.");
        }
    }
}
