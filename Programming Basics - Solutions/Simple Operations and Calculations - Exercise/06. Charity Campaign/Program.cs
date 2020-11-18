using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int corrugations = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakes1 = cakes * 45;
            double corrugations1 = corrugations * 5.80;
            double pancakes1 = pancakes * 3.20;
            double price1 = (cakes1 + corrugations1 + pancakes1) * confectioners;
            double price2 = price1 * days;
            double price3 = 7.0 / 8 * price2;

            Console.WriteLine($"{price3:f2}");
        }
    }
}
