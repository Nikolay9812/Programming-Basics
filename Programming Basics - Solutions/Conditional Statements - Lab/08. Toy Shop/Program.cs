using System;

namespace _08._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int numberPuzzles = int.Parse(Console.ReadLine());
            int numberTalkingDolls = int.Parse(Console.ReadLine());
            int numberTeddyBears = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numberTrucks = int.Parse(Console.ReadLine());

            double puzzlesTotalPrice = numberPuzzles * 2.6;
            double talkingDollsTotalPrice = numberTalkingDolls * 3;
            double teddyBearsTotalPrice = numberTeddyBears * 4.1;
            double minionsTotalPrice = numberMinions * 8.2;
            double trucksTotalPrice = numberTrucks * 2;

            int numberToys = numberPuzzles + numberTalkingDolls + numberTeddyBears
                + numberMinions + numberTrucks;

            double totalPrice = puzzlesTotalPrice + talkingDollsTotalPrice
                + teddyBearsTotalPrice + minionsTotalPrice + trucksTotalPrice;

            if (numberToys >= 50)
            {
                double discount = totalPrice * 0.25;
                totalPrice = totalPrice - discount;
            }

            double taxPayment = totalPrice * 0.10;
            totalPrice = totalPrice - taxPayment;


            if (totalPrice >= excursionPrice)
            {
                double left = totalPrice - excursionPrice;
                Console.WriteLine($"Yes! {left:f2} lv left.");
            }else if (totalPrice <= excursionPrice)
            {
                double left = excursionPrice - totalPrice;
                Console.WriteLine($"Not enough money! {left:f2} lv needed.");
            }
        }
    }
}
