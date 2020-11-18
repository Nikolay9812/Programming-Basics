using System;

namespace _05._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int sum = x1;
            int counter = 0;

            while (sum > 0)
            {
                counter++;
                string x2 = Console.ReadLine();
                if (x2 == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
                    return;
                }
                int x3 = int.Parse(Console.ReadLine());
                if (x2 == "number section")
                {
                    sum -= x3;
                }
                else if (x2 == "double ring")
                {
                    sum -= (x3 * 2);
                }
                else if (x2 == "triple ring")
                {
                    sum -= (x3 * 3);
                }
                
                
                
            }
            if (sum == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {counter} moves!");               
            }
            else
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(sum)}.");
            }
        }
    }
}
