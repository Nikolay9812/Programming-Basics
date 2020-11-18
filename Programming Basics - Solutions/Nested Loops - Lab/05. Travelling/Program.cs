using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {                
                double money = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum < money)
                {
                    double spending = double.Parse(Console.ReadLine());
                    sum += spending;                   
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
