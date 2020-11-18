using System;

namespace _03._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if(10 <= degrees && degrees <= 18)
            {
                if (text == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }else if (text == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }else if (text == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }else if (18 < degrees && degrees <= 24)
            {
                if (text == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (text == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (text == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }else if (degrees >= 25)
            {
                if (text == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (text == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (text == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");


        }
    }
}
