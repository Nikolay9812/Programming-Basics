using System;

namespace _06._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ownDogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double dogfoodPrice = 2.50;
            double animalfoodPrice = 4;
            double totaldogfoodPrice = ownDogs * dogfoodPrice;
            double totalanimalfoodPrice = otherAnimals * animalfoodPrice;
            double sum = totalanimalfoodPrice + totaldogfoodPrice;
            Console.WriteLine($"{sum:f2} lv.");


        }
    }
}