using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (mount == "May" || mount == "October")
            {
                if (numberOfNights > 14)
                {
                    studioPrice = 50 - 50 * 0.3;
                    apartmentPrice = 65 - 65 * 0.1;                    
                }else if (numberOfNights > 7)
                {
                    studioPrice = 50 - 50 * 0.05;
                    apartmentPrice = 65;
                }
                else
                {
                    studioPrice = 50;
                    apartmentPrice = 65;
                }
            }else if (mount == "June" || mount == "September")
            {
                if (numberOfNights > 14)
                {
                    studioPrice = 75.20 - 75.20 * 0.2;
                    apartmentPrice = 68.70 - 68.70 * 0.1;
                }
                else
                {
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                }
            }else if (mount == "July" || mount == "August")
            {
                if (numberOfNights > 14)
                {
                    studioPrice = 76;
                    apartmentPrice = 77 - 77 * 0.1;
                }
                else
                {
                    studioPrice = 76;
                    apartmentPrice = 77;
                }
            }

            double studioFullPrice = studioPrice * numberOfNights;
            double apartmentFullPrice = apartmentPrice * numberOfNights;
            
            Console.WriteLine($"Apartment: {apartmentFullPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioFullPrice:f2} lv.");
        }
    }
}
