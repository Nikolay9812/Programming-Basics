using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int moneyFromBirthDays = 0;
            int moneyGift = 10;
            int toysCount = 0;

            for (int birthDay = 1; birthDay <= age; birthDay++)
            {
                if (birthDay % 2 == 0)
                {
                    moneyFromBirthDays += moneyGift;
                    moneyGift += 10;
                    moneyFromBirthDays -= 1;
                }
                else
                {
                    toysCount++;
                }
            }

            int moneyFromToys = toysCount * toyPrice;
            
            moneyFromBirthDays += moneyFromToys;

            double diffrence = Math.Abs(moneyFromBirthDays - washingMachine);
            
            if (moneyFromBirthDays >= washingMachine)
            {
                Console.WriteLine($"Yes! {diffrence:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diffrence:f2}");
            }

        }
    }
}
