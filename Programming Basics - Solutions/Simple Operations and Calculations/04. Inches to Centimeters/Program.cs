using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();
            double inches = double.Parse(userinput);

            double centimeters = inches * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}
