using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = int.Parse(Console.ReadLine());
            double fensNumber = int.Parse(Console.ReadLine());

            double A = 0;
            double B = 0;
            double V = 0;
            double G = 0;
            double allFenCapacity = 0;
            
            for (int fens = 0; fens < fensNumber; fens++)
            {
                string sector = (Console.ReadLine());
                if (sector == "A") A++;                
                if (sector == "B") B++;
                if (sector == "V") V++;
                if (sector == "G") G++;
            }
            Console.WriteLine($"{A / fensNumber * 100:f2}%");
            Console.WriteLine($"{B / fensNumber * 100:f2}%");
            Console.WriteLine($"{V / fensNumber * 100:f2}%");
            Console.WriteLine($"{G / fensNumber * 100:f2}%");
            Console.WriteLine($"{fensNumber / capacity * 100:f2}%");
        }
    }
}
