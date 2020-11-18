using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());

            double ABC = x1 * x2 * x3;
            double size = (x4 + 0.40) * 2 * 2;
            double space = Math.Floor(ABC / size);

            if (space >= 3 && space < 10)
            {
                Console.WriteLine($"The spacecraft holds {space} astronauts.");
            }
            else if (space < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (space > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
