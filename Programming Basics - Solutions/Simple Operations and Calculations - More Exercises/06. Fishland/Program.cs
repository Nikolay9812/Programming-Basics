using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());
            double fifth = double.Parse(Console.ReadLine());

            double palamud = first + first * 0.60;
            double sumPalamud = third * palamud;
            double safrid = second + second * 0.80;
            double sumSafrid = fourth * safrid;
            double sumClam = fifth * 7.50;
            double sum = sumPalamud + sumSafrid + sumClam;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
