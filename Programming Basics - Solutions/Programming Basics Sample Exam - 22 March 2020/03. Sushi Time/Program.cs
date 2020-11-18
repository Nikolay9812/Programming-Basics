using System;

namespace _03._Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            string x2 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char YorN = char.Parse(Console.ReadLine());

            double sum = 0;
            switch (x1)
            {
                case "sashimi":
                    switch (x2)
                    {
                        case "Sushi Zone":
                            sum = n * 4.99;
                            break;
                        case "Sushi Time":
                            sum = n * 5.49;
                            break;
                        case "Sushi Bar":
                            sum = n * 5.25;
                            break;
                        case "Asian Pub":
                            sum = n * 4.50;
                            break;
                        default:
                            Console.WriteLine($"{x2} is invalid restaurant!");
                            return;
                    }
                    break;
                case "maki":
                    switch (x2)
                    {
                        case "Sushi Zone":
                            sum = n * 5.29;
                            break;
                        case "Sushi Time":
                            sum = n * 4.69;
                            break;
                        case "Sushi Bar":
                            sum = n * 5.55;
                            break;
                        case "Asian Pub":
                            sum = n * 4.80;
                            break;
                        default:
                            Console.WriteLine($"{x2} is invalid restaurant!");
                            return;
                    }
                    break;
                case "uramaki":
                    switch (x2)
                    {
                        case "Sushi Zone":
                            sum = n * 5.99;
                            break;
                        case "Sushi Time":
                            sum = n * 4.49;
                            break;
                        case "Sushi Bar":
                            sum = n * 6.25;
                            break;
                        case "Asian Pub":
                            sum = n * 5.50;
                            break;
                        default:
                            Console.WriteLine($"{x2} is invalid restaurant!");
                            return;
                    }
                    break;
                case "temaki":
                    switch (x2)
                    {
                        case "Sushi Zone":
                            sum = n * 4.29;
                            break;
                        case "Sushi Time":
                            sum = n * 5.19;
                            break;
                        case "Sushi Bar":
                            sum = n * 4.75;
                            break;
                        case "Asian Pub":
                            sum = n * 5.50;
                            break;
                        default:
                            Console.WriteLine($"{x2} is invalid restaurant!");
                            return;
                    }
                    break;
            }
            if (YorN == 'Y')
            {
                sum += sum * 0.2;
                Console.WriteLine($"Total price: {Math.Ceiling(sum)} lv.");
            }
            else if (YorN == 'N')
            {
                Console.WriteLine($"Total price: {Math.Ceiling(sum)} lv.");
            }
        }
    }
}
