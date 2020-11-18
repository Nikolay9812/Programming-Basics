using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string kindOfGroup = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double money = 0;
            string sport = "";

            if (season == "Winter")
            {
                if (kindOfGroup == "boys")
                {
                    money = students * nights * 9.60;
                    sport = "Judo";
                }
                else if (kindOfGroup == "girls")
                {
                    money = students * nights * 9.60;
                    sport = "Gymnastics";
                }
                else if (kindOfGroup == "mixed")
                {
                    money = students * nights * 10;
                    sport = "Ski";
                }
            }else if (season == "Spring")
            {
                if (kindOfGroup == "boys")
                {
                    money = students * nights * 7.20;
                    sport = "Tennis";
                }
                else if (kindOfGroup == "girls")
                {
                    money = students * nights * 7.20;
                    sport = "Athletics";
                }
                else if (kindOfGroup == "mixed")
                {
                    money = students * nights * 9.50;
                    sport = "Cycling";
                }
            }else if (season == "Summer")
            {
                if (kindOfGroup == "boys")
                {
                    money = students * nights * 15;
                    sport = "Football";
                }
                else if (kindOfGroup == "girls")
                {
                    money = students * nights * 15;
                    sport = "Volleyball";
                }
                else if (kindOfGroup == "mixed")
                {
                    money = students * nights * 20;
                    sport = "Swimming";
                }
            }

            if (students >= 50)
            {
                money -= money * 0.5;
            }
            else if (students >= 20 && students < 50)
            {
                money -= money * 0.15;
            }
            else if (students >= 10 && students < 20)
            {
                money -= money * 0.05;
            }
            else
            {
                money = money;
            }

            Console.WriteLine($"{sport} {money:f2} lv.");
        }
    }
}
