using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroup = int.Parse(Console.ReadLine());

            double moneyFromTransport = 0;
            double ticketPrice = 0;

            if (category == "Normal")
            {
                if (peopleInGroup >= 1 && peopleInGroup <= 4)
                {
                    moneyFromTransport = budget - budget * 0.75;
                    ticketPrice = 249.99 * peopleInGroup;
                }else if (peopleInGroup >= 5 && peopleInGroup <= 9)
                {
                    moneyFromTransport = budget - budget * 0.6;
                    ticketPrice = 249.99 * peopleInGroup;
                }else if (peopleInGroup >= 10 && peopleInGroup <= 24)
                {
                    moneyFromTransport = budget - budget * 0.5;
                    ticketPrice = 249.99 * peopleInGroup;
                }else if (peopleInGroup >= 25 && peopleInGroup <= 49)
                {
                    moneyFromTransport = budget - budget * 0.4;
                    ticketPrice = 249.99 * peopleInGroup;
                }else if (peopleInGroup >= 50)
                {
                    moneyFromTransport = budget - budget * 0.25;
                    ticketPrice = 249.99 * peopleInGroup;
                }
            }else if (category == "VIP")
            {
                if (peopleInGroup >= 1 && peopleInGroup <= 4)
                {
                    moneyFromTransport = budget - budget * 0.75;
                    ticketPrice = 499.99 * peopleInGroup;
                }
                else if (peopleInGroup >= 5 && peopleInGroup <= 9)
                {
                    moneyFromTransport = budget - budget * 0.6;
                    ticketPrice = 499.99 * peopleInGroup;
                }
                else if (peopleInGroup >= 10 && peopleInGroup <= 24)
                {
                    moneyFromTransport = budget - budget * 0.5;
                    ticketPrice = 499.99 * peopleInGroup;
                }
                else if (peopleInGroup >= 25 && peopleInGroup <= 49)
                {
                    moneyFromTransport = budget - budget * 0.4;
                    ticketPrice = 499.99 * peopleInGroup;
                }
                else if (peopleInGroup >= 50)
                {
                    moneyFromTransport = budget - budget * 0.25;
                    ticketPrice = 499.99 * peopleInGroup;
                }
            }

            if (ticketPrice < moneyFromTransport)
            {
                double leftMoney = moneyFromTransport - ticketPrice;
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }else if (ticketPrice > moneyFromTransport)
            {
                double neededMoney = ticketPrice - moneyFromTransport;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
        }
    }
}
