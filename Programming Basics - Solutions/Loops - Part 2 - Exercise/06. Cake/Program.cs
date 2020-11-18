using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int pieces = length * width;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int takenPeaces = int.Parse(command);
                pieces -= takenPeaces;

                if (pieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
