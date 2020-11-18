using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isBookFound = false;

            string nextbookName = Console.ReadLine();

            while (counter < numberOfBooks)
            {
                if (nextbookName == bookName)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextbookName = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");
            }

        }
    }
}
