using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            int counter2 = 0;
            double sum = 0;

            while (command != "End")
            {
                double value = double.Parse(command);
                counter++;
                n -= value;
                if (counter % 3 == 0)
                {
                    n -= (value * 0.1);
                }
                if (n < 0)
                {
                    counter--;
                    Console.WriteLine("No more space!");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
