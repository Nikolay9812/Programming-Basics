using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
			double worldRecord = double.Parse(Console.ReadLine());
			double distanceInM = double.Parse(Console.ReadLine());
			double timePerM = double.Parse(Console.ReadLine());

			double timesDelay = Math.Floor(distanceInM / 15);
			double secondsDelay = timesDelay * 12.5;
			double chalengerTime = timePerM * distanceInM + secondsDelay;

			if (chalengerTime < worldRecord)
			{
				Console.WriteLine(" Yes, he succeeded! The new world record is {0:f2} seconds.", chalengerTime);
			}
			else
			{
				double difference = Math.Abs(chalengerTime - worldRecord);
				Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", difference);
			}
        }
    }
}
