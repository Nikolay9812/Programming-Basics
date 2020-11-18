using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double results = Math.Floor(minimalSalary * 0.35);
            double procent = Math.Floor(averageSuccess * 25);

            if (averageSuccess < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (averageSuccess >= 4.50 && averageSuccess < 5.50)
            {
                if (minimalSalary < income)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (minimalSalary >= income)
                {
                    Console.WriteLine($"You get a Social scholarship {results} BGN");
                }
            }
            else if (averageSuccess >= 5.50)
            {
                if (minimalSalary < income)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {procent} BGN");
                }
                else if (minimalSalary >= income && results > procent)
                {
                    Console.WriteLine($"You get a Social scholarship {results} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {procent} BGN");
                }
            }
        }
    }
}
