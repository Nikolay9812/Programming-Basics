using System;

namespace _09._Weater_Forecast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (text != "sunny")
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}