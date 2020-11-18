using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double row = Math.Truncate(lenght / 1.2);
            double colomn = Math.Truncate((width - 1) / 0.7);

            double place = (row * colomn) - 3;

            Console.WriteLine(place);
        }
    }
}
