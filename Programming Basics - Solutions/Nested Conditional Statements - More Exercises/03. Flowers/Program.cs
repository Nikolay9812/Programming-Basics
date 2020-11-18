using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumberOfChrysanthemumsPurchased = int.Parse(Console.ReadLine());
            int theNumberOfRosesPurchased = int.Parse(Console.ReadLine());
            int theNumberOfTulipsPurchased = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string whetherTheDayIsAHoliday = Console.ReadLine();

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            double totalPrice = 0;
            int discount = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumsPrice = 2;
                    rosesPrice = 4.1;
                    tulipsPrice = 2.5;
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.50;
                    tulipsPrice = 4.15;
                    break;
            }
            totalPrice = theNumberOfChrysanthemumsPurchased * chrysanthemumsPrice
                + theNumberOfRosesPurchased * rosesPrice
                + theNumberOfTulipsPurchased * tulipsPrice; ;
            if (whetherTheDayIsAHoliday == "Y")
            {
                totalPrice *= 1.15;

            }
            if (season == "Spring" && theNumberOfTulipsPurchased > 7)
            {
                discount += 5;
                totalPrice = totalPrice - ((totalPrice * discount) / 100);
            }
            if (season == "Winter" && theNumberOfRosesPurchased >= 10)
            {
                discount = 10;
                totalPrice = totalPrice - ((totalPrice * discount) / 100);
            }
            if (theNumberOfChrysanthemumsPurchased + theNumberOfRosesPurchased + theNumberOfTulipsPurchased > 20)
            {
                discount = 20;
                totalPrice = totalPrice - ((totalPrice * discount) / 100);
            }

            Console.WriteLine("{0:f2}", totalPrice + 2);
        }
    }
}