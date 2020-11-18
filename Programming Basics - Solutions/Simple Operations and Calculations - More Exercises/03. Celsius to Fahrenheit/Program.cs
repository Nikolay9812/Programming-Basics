using System;

namespace _03._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());

            double Fformula = C * 1.8 + 32;

            Console.WriteLine($"{Fformula:f2}");
        }
    }       
}
