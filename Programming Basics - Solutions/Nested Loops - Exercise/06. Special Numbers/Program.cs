using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digitOfOnes = 0;
            int digitOfTens = 0;
            int digitOfHundreds = 0;
            int digitOfThousands = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                digitOfThousands = i / 1000;
                digitOfHundreds = (i / 100) % 10;
                digitOfTens = (i / 10) % 10;
                digitOfOnes = i % 10;
                if (digitOfThousands == 0 || digitOfHundreds == 0 || digitOfTens == 0 || digitOfOnes == 0)
                {
                    continue;
                }
                if (n % digitOfOnes == 0 && n % digitOfTens == 0 && n % digitOfHundreds == 0 && n % digitOfThousands == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}