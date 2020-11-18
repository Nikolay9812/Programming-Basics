using System;

namespace _07._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakiq = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double rakiqPrice = whiskeyPrice / 2;
            double winePrice = rakiqPrice - (rakiqPrice * 0.4);
            double beerPrice = rakiqPrice - (rakiqPrice * 0.8);
            double sumrakiq = rakiq * rakiqPrice;
            double sumwine = wine * winePrice;
            double sumbeer = beer * beerPrice;
            double sumwhiskey = whiskey * whiskeyPrice;
            double all = sumrakiq + sumwine + sumbeer + sumwhiskey;

            Console.WriteLine($"{all:f2}");

        }
    }
}
