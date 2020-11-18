using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTickets = 0;
            int student = 0;
            int standard = 0;
            int kid = 0;
            while (movie != "Finish")
            {
                int emptyPlace = int.Parse(Console.ReadLine());
                string typeOfTicket = Console.ReadLine();
                int counter = 0;
                while (typeOfTicket != "End")
                {
                    switch (typeOfTicket)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                    counter++;
                    if (emptyPlace == counter)
                    {
                        break;
                    }
                    typeOfTicket = Console.ReadLine();
                }
                totalTickets += counter;

                double totalPlaces = counter * 1.0 / emptyPlace * 100;
                Console.WriteLine($"{movie} - {totalPlaces:f2}% full.");
                movie = Console.ReadLine();               
            }
            double studentTickets = student * 1.0 / totalTickets * 100;
            double standardTickets = standard * 1.0 / totalTickets * 100;
            double kidTickets = kid * 1.0 / totalTickets * 100;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets:f2}% kids tickets.");
        }
    }
}
