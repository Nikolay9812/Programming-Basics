using System;

namespace _09._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double seling = double.Parse(Console.ReadLine());

            double commissions = 0;

            if(city == "Sofia")
            {
                if(seling >= 0 && seling <= 500)
                {
                    commissions = seling * 0.05;
                }
                else if (seling > 500 && seling <= 1000)
                {
                    commissions = seling * 0.07;
                }
                else if (seling > 1000 && seling <= 10000)
                {
                    commissions = seling * 0.08;
                }else if (seling > 10000)
                {
                    commissions = seling * 0.12;
                }

            }
            else if (city == "Varna")
            {
                if (seling >= 0 && seling <= 500)
                {
                    commissions = seling * 0.045;
                }
                else if (seling > 500 && seling <= 1000)
                {
                    commissions = seling * 0.075;
                }
                else if (seling > 1000 && seling <= 10000)
                {
                    commissions = seling * 0.1;
                }
                else if (seling > 10000)
                {
                    commissions = seling * 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (seling >= 0 && seling <= 500)
                {
                    commissions = seling * 0.055;
                }
                else if (seling > 500 && seling <= 1000)
                {
                    commissions = seling * 0.08;
                }
                else if (seling > 1000 && seling <= 10000)
                {
                    commissions = seling * 0.12;
                }
                else if (seling > 10000)
                {
                    commissions = seling * 0.145;
                }
            }

            if(commissions > 0)
            {
                Console.WriteLine($"{commissions:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
