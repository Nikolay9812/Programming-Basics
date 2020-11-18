using System;

namespace _04._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int countStops = int.Parse(Console.ReadLine());

            int getOff = 0;
            int getIn = 0;

            for (int i = 1; i <= countStops; i++)
            {
                getOff = int.Parse(Console.ReadLine());
                getIn = int.Parse(Console.ReadLine());
                passengers -= getOff;
                passengers += getIn;

                if (i % 2 == 1)
                {
                    passengers += 2;
                }
                else if (i % 2 == 0)
                {
                    passengers -= 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
