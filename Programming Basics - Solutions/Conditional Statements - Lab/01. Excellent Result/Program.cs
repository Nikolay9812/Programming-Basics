using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 6.01)
            {
                Console.WriteLine();
            }else if (number <= 5.49)
            {
                Console.WriteLine();
            }else if (number <= 6)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
