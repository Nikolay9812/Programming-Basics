using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumToConvert = double.Parse(Console.ReadLine());
            string inputMeasure = Console.ReadLine();
            string outputMeasure = Console.ReadLine();

            if (inputMeasure == "mm")
            {
                sumToConvert = sumToConvert / 1000;
            }
            else if (inputMeasure == "cm")
            {
                sumToConvert = sumToConvert / 100;
            }
            else if (inputMeasure == "mi")
            {
                sumToConvert = sumToConvert / 0.000621371192;
            }
            else if (inputMeasure == "in")
            {
                sumToConvert = sumToConvert / 39.3700787;
            }
            else if (inputMeasure == "km")
            {
                sumToConvert = sumToConvert / 0.001;
            }
            else if (inputMeasure == "ft")
            {
                sumToConvert = sumToConvert / 3.2808399;
            }
            else if (inputMeasure == "yd")
            {
                sumToConvert = sumToConvert / 1.0936133;
            }

            if (outputMeasure == "mm")
            {
                sumToConvert = sumToConvert * 1000;
            }
            else if (outputMeasure == "cm")
            {
                sumToConvert = sumToConvert * 100;
            }
            else if (outputMeasure == "mi")
            {
                sumToConvert = sumToConvert * 0.000621371192;
            }
            else if (outputMeasure == "in")
            {
                sumToConvert = sumToConvert * 39.3700787;
            }
            else if (outputMeasure == "km")
            {
                sumToConvert = sumToConvert * 0.001;
            }
            else if (outputMeasure == "ft")
            {
                sumToConvert = sumToConvert * 3.2808399;
            }
            else if (outputMeasure == "yd")
            {
                sumToConvert = sumToConvert * 1.0936133;
            }
            Console.Write($"{sumToConvert:f3}");
        }
    }
}
