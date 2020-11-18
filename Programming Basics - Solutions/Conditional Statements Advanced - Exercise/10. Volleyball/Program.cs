using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wekendsYear = 48 - h;
            double saturdayGames = wekendsYear * 3 / 4;
            double holidays = p * 2 / 3;
            double allGames = saturdayGames + h + holidays;

            if (text == "leap")
            {
                double more = allGames + allGames * 0.15;
                Console.WriteLine("{0}",Math.Floor(more));
            }else if (text == "normal")
            {
                Console.WriteLine("{0}",Math.Floor(allGames));
            }
        }
    }
}
