using System;

namespace _06._Shelter_for_Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double sum = 0;
            double gram = n * 1000;

            while (command != "Adopted")
            {
                int value = int.Parse(command);
                sum += value;
                command = Console.ReadLine();
            }
            if (gram >= sum)
            {
                Console.WriteLine($"Food is enough! Leftovers: {gram - sum} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sum - gram} grams more.");
            }
        }
    }
}
