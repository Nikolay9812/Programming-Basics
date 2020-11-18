using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFreeDays = int.Parse(Console.ReadLine());

            double freeDays = numberFreeDays * 127;
            double workDays = (365 - numberFreeDays) * 63;
            double playTime = freeDays + workDays;
            double diffrence = Math.Abs(playTime - 30000);
            double hours = Math.Floor(diffrence / 60);
            double minutes = diffrence % 60;

            if (30000 > playTime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
