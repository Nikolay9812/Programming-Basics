using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            int currentClass = 1;
            double totalGrades = 0;

            while (currentClass <= 12)
            {

                if (grade >= 4.00)
                {
                    totalGrades += grade;
                    currentClass++;
                }
                if (currentClass < 13)
                {
                    grade = double.Parse(Console.ReadLine());
                }
            }
            double averageGrade = totalGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
