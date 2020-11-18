using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int weigth = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volum = lenght * weigth * height;
            double liters = volum * 0.001;
            percent = percent / 100;

            double literstaken = liters * percent;
            double freeSpace = liters - literstaken;

            Console.WriteLine("{0:F3}", freeSpace);


        }
    }
}
