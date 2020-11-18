using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int magickNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool condition = false;

            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = firstNum; j <= lastNum; j++)
                {
                    counter++;
                    int sum = i + j;
                    if (sum == magickNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magickNum})");
                        condition = true;
                        break;
                    }
                }
                if (condition)
                {
                    break;
                }
            }
            
            if (!condition)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magickNum}");
            }
            
        }
    }
}
