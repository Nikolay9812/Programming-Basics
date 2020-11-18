using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се вземат стойностите на еденици, десети и стотици в отделни променливи
            // Да се завъртят в цикли за умножение между създадените промнливи

            int n = int.Parse(Console.ReadLine());      // Чете трицифрено число

            int singleDigitNum = 0;
            int doubleDigitNum = 0;
            int tripleDigitNum = 0;

            singleDigitNum = n % 10;
            doubleDigitNum = (n / 10) % 10;
            tripleDigitNum = n / 100;

            for (int singleD = 1; singleD <= singleDigitNum; singleD++)
            {
                for (int doubleD = 1; doubleD <= doubleDigitNum; doubleD++)
                {
                    for (int tripleD = 1; tripleD <= tripleDigitNum; tripleD++)
                    {
                        Console.WriteLine($"{singleD} * {doubleD} * {tripleD} = {singleD * doubleD * tripleD};");                       
                    }
                }
            }
        }
    }
}