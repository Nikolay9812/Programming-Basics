using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());

            double A = x2 * 2 / 3;
            double B = A * 0.75;
            double C = (x2 + B) * 1 / 3;
            double D = x2 + A + B + C;
            double E = D - (x3 * D / 100);

            if (x1 >= E)
            {
                Console.WriteLine($"Annie's sum is {E:f2} lv. She has {x1-E:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {E:f2} lv. She needs {E-x1:f2} lv. more.");
            }
        }
    }
}
