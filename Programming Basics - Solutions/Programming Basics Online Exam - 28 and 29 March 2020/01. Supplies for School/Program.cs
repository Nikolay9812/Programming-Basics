using System;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            double A = n1 * 5.80;
            double B = n2 * 7.20;
            double C = n3 * 1.20;
            double ABC = A + B + C;
            double sum = ABC - ((ABC * n4 / 100));

            Console.WriteLine($"{sum:f3}");
        }
    }
}
