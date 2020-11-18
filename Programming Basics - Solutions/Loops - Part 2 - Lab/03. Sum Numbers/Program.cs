using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int n = 0;
            int sum = 0;

            while (command != "Stop")
            {
                n = int.Parse(command);
                sum += n;
                command = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
