using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double dog = numberOfDays * dogFood;
            double cat = numberOfDays * catFood;
            double turtle = (numberOfDays * turtleFood) / 1000;

            double allFood = dog + cat + turtle;
            double food = Math.Abs(allFood - leftFood);

            if (allFood <= leftFood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(food));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(food));
            }
        }
    }
}
