using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = int.Parse(Console.ReadLine());
            double N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double results = 0;

            if (symbol == '+')
            {
                results = N1 + N2;

                if (results % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {results} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {results} - odd");
                }
            }
            else if (symbol == '-')
            {
                results = N1 - N2;

                if (results % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {results} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {results} - odd");
                }
            }
            else if (symbol == '*')
            {
                results = N1 * N2;

                if (results % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {results} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {results} - odd");
                }
            }
            else if (symbol == '/')
            {

                if (N2 != 0)
                {
                    results = N1 / N2;
                    Console.WriteLine($"{N1} {symbol} {N2} = {results:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }            
            }
            else if (symbol == '%')
            {

                if (N2 != 0)
                {
                    results = N1 % N2;
                    Console.WriteLine($"{N1} {symbol} {N2} = {results}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }

        }
    }
}
