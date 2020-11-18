using System;

namespace _09._Graduation_pt._2
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
                if (grade <= 2.00)
                {
                    Console.WriteLine($"{name} has been excluded at {currentClass} grade");
                    return;
                }
            }
            double averageGrade = totalGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
