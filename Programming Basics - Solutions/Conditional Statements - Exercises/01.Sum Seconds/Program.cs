using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());

            int s1 = x1 + x2 + x3;

            if (s1 < 10)
            {
                Console.WriteLine("0:0" + s1);
            }
            else if (s1 >= 10 && s1 < 60)
            {
                Console.WriteLine("0:" + s1);
            }
            else if (s1 >= 60 && s1 < 70)
            {
                Console.WriteLine("1:0" + (s1 - 60));
            }
            else if (s1 >= 70 && s1 < 120)
            {
                Console.WriteLine("1:" + (s1 - 60));
            }
            else if (s1 >= 120 && s1 < 130)
            {
                Console.WriteLine("2:0" + (s1 - 120));
            }
            else if (s1 >= 130 && s1 < 180)
            {
                Console.WriteLine("2:" + (s1 - 120));
            }

        }
    }
}