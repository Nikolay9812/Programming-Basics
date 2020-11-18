using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int daysFirmHave = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double procent = daysFirmHave - (daysFirmHave * 0.1);
            double hoursForTeaching = 8 * procent;
            double workers = numberOfWorkers * (2 * daysFirmHave);
            double allHours = Math.Floor(hoursForTeaching + workers);
            double diference = Math.Abs(allHours - neededHours);

            if (allHours >= neededHours)
            {
                Console.WriteLine($"Yes!{diference} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{diference} hours needed.");
            }

        }
    }
}
