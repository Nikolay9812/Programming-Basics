using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double P1Full = H * P1;
            double P2Full = H * P2;
            double all = P1Full + P2Full;
            double procentFull = (all / V) * 100;
            double procentFullP1 = (P1Full / all) * 100;
            double procentFullP2 = (P2Full / all) * 100;

            if (all <= V)
            {
                Console.WriteLine($"The pool is {procentFull:f2}% full." +
                    $"Pipe 1: {procentFullP1:f2}%. Pipe 2: {procentFullP2:f2}%.");
            }
            else
            {
                double overflows = all - V;
                Console.WriteLine($"For {H:f2} hours the pool overflows with {overflows:f2} liters.");
            }
        }
    }
}
