using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            double sumVeg = first * third;
            double sumFrut = second * fourth;

            double all = sumVeg + sumFrut;
            double allEvro = all / 1.94;

            Console.WriteLine($"{allEvro:f2}");
        }
    }
}
