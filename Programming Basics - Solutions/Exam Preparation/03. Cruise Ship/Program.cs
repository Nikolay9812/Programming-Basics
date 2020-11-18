using System;

namespace _03._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            string x2 = Console.ReadLine();
            int x3 = int.Parse(Console.ReadLine());
            double sum = 0;

            switch (x1)
            {
                case "Mediterranean":
                    switch (x2)
                    {
                        case "standard cabin":
                            sum = 27.50 * 4 * x3;
                            break;
                        case "cabin with balcony":
                            sum = 30.20 * 4 * x3;
                            break;
                        case "apartment":
                            sum = 40.50 * 4 * x3;
                            break;
                    }
                    break;
                case "Adriatic":
                    switch (x2)
                    {
                        case "standard cabin":
                            sum = 22.99 * 4 * x3;
                            break;
                        case "cabin with balcony":
                            sum = 25.00 * 4 * x3;
                            break;
                        case "apartment":
                            sum = 34.99 * 4 * x3;
                            break;
                    }
                    break;
                case "Aegean":
                    switch (x2)
                    {
                        case "standard cabin":
                            sum = 23 * 4 * x3;
                            break;
                        case "cabin with balcony":
                            sum = 26.60 * 4 * x3;
                            break;
                        case "apartment":
                            sum = 39.80 * 4 * x3;
                            break;
                    }
                    break;
            }
            if (x3 > 7)
            {
                Console.WriteLine($"Annie's holiday in the {x1} sea costs {sum*0.75:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Annie's holiday in the {x1} sea costs {sum:f2} lv.");
            }
        }
    }
}
