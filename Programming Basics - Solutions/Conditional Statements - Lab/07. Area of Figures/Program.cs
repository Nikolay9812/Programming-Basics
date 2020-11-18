using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string kind = Console.ReadLine();
            double size = 0;

            if (kind == "square")
            {
                double a = double.Parse(Console.ReadLine());
                size = a * a;
            }else if (kind == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                size = a * b;
            }else if (kind == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                size = Math.PI * r * r;
            }else if ( kind == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                size = a * b / 2;
            }

            Console.WriteLine($"{size:f3}");
        }
    }
}
