using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumSteps = 0;
            int daySteps = 0;

            while (command != "Going home")
            {
                daySteps = int.Parse(command);
                sumSteps += daySteps;
                if (sumSteps >= 10000)
                {

                    break;
                }
                command = Console.ReadLine();
            }
            if (sumSteps < 10000)
            {
                command = Console.ReadLine();
                daySteps = int.Parse(command);
                sumSteps += daySteps;
                if (sumSteps < 10000)
                {
                    int needSteps = 10000 - sumSteps;
                    Console.WriteLine($"{needSteps} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
