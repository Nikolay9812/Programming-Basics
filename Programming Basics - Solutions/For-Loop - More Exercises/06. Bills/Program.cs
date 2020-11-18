using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounts = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 0;
            double internet = 0;
            double others = 0;
            double average = 0;

            for (int i = 0; i < mounts; i++)
            {
                double eachMount = double.Parse(Console.ReadLine());

                electricity += eachMount;
                water = 20 * mounts;
                internet = 15 * mounts;
                double sum = (eachMount + 20 + 15) * 1.2;
                others += sum;
                average = (electricity + water + internet + others) / mounts;
            }
            Console.WriteLine("Electricity: {0:f2} lv", electricity);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", others);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}