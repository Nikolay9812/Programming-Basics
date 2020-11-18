using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double d = 2 * r;
            double S1 = Math.PI * (d * d) / 4;
            double P = 2 * Math.PI * r;

            Console.WriteLine($"{S1:f2}");
            Console.WriteLine($"{P:f2}");
        }
    }
}
