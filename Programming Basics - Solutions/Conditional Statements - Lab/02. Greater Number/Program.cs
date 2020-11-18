using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }else if (numberOne < numberTwo)
            {
                Console.WriteLine(numberTwo);
            }else if (numberOne == numberTwo)
            {
                Console.WriteLine(numberOne);
            }
        }
    }
}
