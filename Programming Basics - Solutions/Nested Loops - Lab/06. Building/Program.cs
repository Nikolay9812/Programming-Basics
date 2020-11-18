using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            string type = "";

            for (int j = floor; j >= 1; j--)
            {
                for (int i = 0; i < room; i++)
                {                   
                    if (j == floor)
                    {
                        type = "L";
                    }else if (j % 2 == 0)
                    {
                        type = "O";
                    }else if (j % 1 == 0)
                    {
                        type = "A";
                    }
                    Console.Write($"{type + j + i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
