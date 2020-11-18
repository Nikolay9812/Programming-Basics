using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wall = x * y;
            double window = 1.5 * 1.5;
            double twoSides = 2 * wall - 2 * window;
            double backWall = x * x;
            double entry = 1.2 * 2;
            double totalFrontAndBack = 2 * backWall - entry;

            double totalArea = twoSides + totalFrontAndBack;
            double greenPaint = totalArea / 3.4;

            double first = 2 * (x * y);
            double second = 2 * (x * h / 2);

            double totalArea1 = first + second;
            double redPaint = totalArea1 / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");


        }
    }
}
