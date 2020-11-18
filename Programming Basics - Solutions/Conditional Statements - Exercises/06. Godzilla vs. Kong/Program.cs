using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int numberSupernumerary = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double sumDecor = movieBudget * 0.1;
            double sumClothes = numberSupernumerary * clothingPrice;

            if (numberSupernumerary > 150)
            {
                sumClothes = sumClothes * 0.9;
            }

            double sumMovie = sumDecor + sumClothes;
            double leftMoney = Math.Abs(movieBudget - sumMovie);

            if (movieBudget < sumMovie)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {leftMoney:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }
        }
    }
}
