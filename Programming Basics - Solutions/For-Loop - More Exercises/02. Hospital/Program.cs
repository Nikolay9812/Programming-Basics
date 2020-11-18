using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;

            for (int days = 1; days <= period; days ++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (days % 3 == 0 && treatedPatients < untreatedPatients)
                {
                    doctors++;
                }
                if (patients > doctors)
                {
                    untreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }
                else
                {
                    treatedPatients += patients;
                }
            }
            Console.WriteLine("Treated patients: " + treatedPatients + ".");
            Console.WriteLine("Untreated patients: " + untreatedPatients + ".");
        }
    }
}
