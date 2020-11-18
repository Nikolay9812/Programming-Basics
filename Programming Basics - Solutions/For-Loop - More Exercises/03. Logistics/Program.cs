using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int TheNumberOfCargo = int.Parse(Console.ReadLine());
            double priceMiniBus = 0;
            double priceТruck = 0;
            double priceTrain = 0;
            double sumCargoMiniBus = 0;
            double sumCargoТruck = 0;
            double sumCargoTrain = 0;
            double sumCargo = 0;
            for (int i = 1; i <= TheNumberOfCargo; i++)
            {
                int theTonnageOfCargo = int.Parse(Console.ReadLine());
                sumCargo += theTonnageOfCargo;
                if (theTonnageOfCargo <= 3)
                {
                    sumCargoMiniBus += theTonnageOfCargo;
                    priceMiniBus += theTonnageOfCargo * 200;
                }
                if (theTonnageOfCargo > 3 && theTonnageOfCargo <= 11)
                {
                    sumCargoТruck += theTonnageOfCargo;
                    priceТruck += theTonnageOfCargo * 175;
                }
                if (theTonnageOfCargo > 11)
                {
                    sumCargoTrain += theTonnageOfCargo;
                    priceTrain += theTonnageOfCargo * 120;
                }
            }
            double sumAveragePrice = (priceMiniBus + priceТruck + priceTrain) / sumCargo;
            double percentCargoMinibus = sumCargoMiniBus / sumCargo * 100;
            double percentCargoTruck = sumCargoТruck / sumCargo * 100;
            double percentCargoTrain = sumCargoTrain / sumCargo * 100;
            Console.WriteLine($"{sumAveragePrice:f2}");
            Console.WriteLine($"{percentCargoMinibus:f2}%");
            Console.WriteLine($"{percentCargoTruck:f2}%");
            Console.WriteLine($"{percentCargoTrain:f2}%");
        }
    }
}
