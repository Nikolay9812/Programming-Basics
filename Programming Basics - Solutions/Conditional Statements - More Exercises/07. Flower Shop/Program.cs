using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMagnolias = int.Parse(Console.ReadLine());
            int numberHyacinths = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberCactus = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double sum = numberMagnolias * 3.25 + numberHyacinths * 4
                + numberRoses * 3.5 + numberCactus * 8;
            double taxes = sum - sum * 0.05;

            if (taxes < giftPrice)
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(giftPrice - taxes));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.",Math.Floor(taxes - giftPrice));
            }
        }
    }
}
