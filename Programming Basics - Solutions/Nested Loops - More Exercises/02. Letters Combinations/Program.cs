using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();
            string result = "";
            int counter = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        result = $"{i}{j}{k}";
                        if (!result.Contains(skip))
                        {
                            Console.Write(result + " ");
                            counter++;
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
