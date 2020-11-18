using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double harvest = (x * 0.4) * y;
            double wine = (harvest / 2.5);
            double litersLeft = Math.Abs(wine - z);
            double workersLitres = (litersLeft / workers);

            if (wine < z)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(litersLeft));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person."
                    , Math.Ceiling(litersLeft), Math.Ceiling(workersLitres));
            }

        }
    }
}