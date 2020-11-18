using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt1 = Console.ReadLine();
            string txt2 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            switch (txt1)
            {
                case "Watermelon":
                    switch (txt2)
                    {
                        case "small":
                            sum = (2 * 56) * n;
                            break;
                        case "big":
                            sum = (5 * 28.70) * n;
                            break;
                    }
                    break;
                case "Mango":
                    switch (txt2)
                    {
                        case "small":
                            sum = (2 * 36.66) * n;
                            break;
                        case "big":
                            sum = (5 * 19.60) * n;
                            break;
                    }
                    break;
                case "Pineapple":
                    switch (txt2)
                    {
                        case "small":
                            sum = (2 * 42.10) * n;
                            break;
                        case "big":
                            sum = (5 * 24.80) * n;
                            break;
                    }
                    break;
                case "Raspberry":
                    switch (txt2)
                    {
                        case "small":
                            sum = (2 * 20) * n;
                            break;
                        case "big":
                            sum = (5 * 15.20) * n;
                            break;
                    }
                    break;
            }
            if (400 <= sum && sum <= 1000)
            {
                Console.WriteLine($"{sum * 0.85:f2} lv.");
            }
            else if (sum > 1000)
            {
                Console.WriteLine($"{sum * 0.5:f2} lv.");
            }
        }
    }
}
