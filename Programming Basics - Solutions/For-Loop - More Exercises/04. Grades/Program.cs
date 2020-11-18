using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            int greaterThanFive = 0;
            int betweenFourAndFive = 0;
            int betweenThreeAndFour = 0;
            int PoorerThanThree = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                double gradeInput = double.Parse(Console.ReadLine());
                if (gradeInput >= 5.00) greaterThanFive++;
                if (gradeInput >= 4.00 && gradeInput <= 4.99) betweenFourAndFive++;
                if (gradeInput >= 3.00 && gradeInput <= 3.99) betweenThreeAndFour++;
                if (gradeInput < 3.00) PoorerThanThree++;
                average += gradeInput;
            }

            Console.WriteLine("Top students: {0:f2}%", (greaterThanFive / students) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (betweenFourAndFive / students) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (betweenThreeAndFour / students) * 100);
            Console.WriteLine("Fail: {0:f2}%", (PoorerThanThree / students) * 100);
            Console.WriteLine("Average: {0:f2}", average / students);
        }
    }
}
