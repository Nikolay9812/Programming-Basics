using System;

namespace _05._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int value = int.Parse(Console.ReadLine());

            int number = value * 3;

            Console.WriteLine("The architect " + Name + " will need " + number + " hours to complete " + value + " project/s.");





        }
    }
}
