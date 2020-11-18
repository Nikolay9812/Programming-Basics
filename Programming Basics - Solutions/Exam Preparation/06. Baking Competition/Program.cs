using System;

namespace _06._Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());

            int countCookies = 0;
            int countCakes = 0;
            int countWaffles = 0;

            int countersweetsAll = 0;

            double sum = 0;
            double sumEnd = 0;

            for (int i = 1; i <= countOfPeople; i++)
            {
                countCookies = 0;
                countCakes = 0;
                countWaffles = 0;


                string name = Console.ReadLine();
                string command = Console.ReadLine();

                while (command != "Stop baking!")
                {
                    string sweetName = command;

                    int countOfSweets = int.Parse(Console.ReadLine());

                    countersweetsAll += countOfSweets;

                    if (sweetName == "cookies")
                    {
                        countCookies += countOfSweets;
                        sum = countOfSweets * 1.50;
                    }
                    else if (sweetName == "cakes")
                    {
                        countCakes += countOfSweets;
                        sum = countOfSweets * 7.80;

                    }
                    else if (sweetName == "waffles")
                    {
                        countWaffles += countOfSweets;
                        sum = countOfSweets * 2.30;
                    }

                    sumEnd += sum;
                    sum = 0;

                    command = Console.ReadLine();
                }
                if (command == "Stop baking!")
                {
                    Console.WriteLine($"{name} baked {countCookies} cookies, {countCakes} cakes and {countWaffles} waffles.");
                }
            }

            Console.WriteLine($"All bakery sold: {countersweetsAll}");
            Console.WriteLine($"Total sum for charity: {sumEnd:F2} lv.");

        }
    }
}
