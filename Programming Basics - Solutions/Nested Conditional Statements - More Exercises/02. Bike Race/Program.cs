using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumberOfJuniorCyclists = int.Parse(Console.ReadLine());
            int theNumberOfSeniorCyclists = int.Parse(Console.ReadLine());
            string kindOfTrack = Console.ReadLine();

            double juniors = 0;
            double seniors = 0;
            double totalJuniorAndSenior = theNumberOfJuniorCyclists + theNumberOfSeniorCyclists;
            double collectedAmount = 0;
            double left = 0;

            if (kindOfTrack == "trail")
            {
                juniors = 5.5;
                seniors = 7;
                collectedAmount = theNumberOfJuniorCyclists * juniors
                    + theNumberOfSeniorCyclists * seniors;
                left = collectedAmount - collectedAmount * 0.05;
            }
            else if (kindOfTrack == "cross-country")
            {
                if (totalJuniorAndSenior < 50)
                {
                    juniors = 8;
                    seniors = 9.5;
                    collectedAmount = theNumberOfJuniorCyclists * juniors
                        + theNumberOfSeniorCyclists * seniors;
                    left = collectedAmount - collectedAmount * 0.05;
                }else if (totalJuniorAndSenior >= 50)
                {
                    juniors = 8 - 8 * 0.25;
                    seniors = 9.5 - 9.5 * 0.25;
                    collectedAmount = theNumberOfJuniorCyclists * juniors
                        + theNumberOfSeniorCyclists * seniors;
                    left = collectedAmount - collectedAmount * 0.05;
                }
            }
            else if (kindOfTrack == "downhill")
            {
                juniors = 12.25;
                seniors = 13.75;
                collectedAmount = theNumberOfJuniorCyclists * juniors
                    + theNumberOfSeniorCyclists * seniors;
                left = collectedAmount - collectedAmount * 0.05;
            }
            else if (kindOfTrack == "road")
            {
                juniors = 20;
                seniors = 21.50;
                collectedAmount = theNumberOfJuniorCyclists * juniors
                    + theNumberOfSeniorCyclists * seniors;
                left = collectedAmount - collectedAmount * 0.05;
            }

            Console.WriteLine($"{left:f2}");

        }
    }
}
