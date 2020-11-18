using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sum = (hours * 60) + minutes + 15;
            double sumHours = sum / 60;

            if(sumHours >= 24)
            {
                sumHours = sumHours - 24;
            }

            double sumMinutes = sum % 60;

            Console.WriteLine("{0}:{1:00}", sumHours, sumMinutes);


        }
    }
}
