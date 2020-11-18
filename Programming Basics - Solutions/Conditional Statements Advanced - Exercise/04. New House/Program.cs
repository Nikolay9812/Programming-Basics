using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double neededMoney = 0;
            double leftMoney = 0;

            switch (typeOfFlowers)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
            }

            double totalPrice = numberOfFlowers * price;

            if (numberOfFlowers > 80 && typeOfFlowers == "Roses")
            {
                totalPrice = totalPrice * 0.9;
            }
            else if (numberOfFlowers > 90 && typeOfFlowers == "Dahlias")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (numberOfFlowers > 80 && typeOfFlowers == "Tulips")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (numberOfFlowers < 120 && typeOfFlowers == "Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            else if (numberOfFlowers < 80 && typeOfFlowers == "Gladiolus")
            {
                totalPrice = totalPrice + 0.20 * totalPrice;
            }

            if (totalPrice > budget)
            {
                neededMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }else if (totalPrice <= budget)
            {
                leftMoney = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {leftMoney:f2} leva left.");
            }
        }    
    }
}
