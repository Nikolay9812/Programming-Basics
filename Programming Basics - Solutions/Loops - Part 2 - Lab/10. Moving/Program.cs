using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int higth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int roomVolume = width * length * higth;

            while(command != "Done")
            {
                int numberOfBoxes = int.Parse(command);
                roomVolume -= numberOfBoxes;
                if (roomVolume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(roomVolume)} Cubic meters more.");
                    return;
                }
                command = Console.ReadLine();
            }
            
            Console.WriteLine($"{roomVolume} Cubic meters left.");
        }
    }
}
