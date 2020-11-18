using System;

namespace _07._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool difrence = (number >= 100) && (number <= 200) || number == 0;

            if (!difrence)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
