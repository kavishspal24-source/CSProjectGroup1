using System;

namespace CSProjectGroup1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();

            Console.Write("Enter first name: ");
            p.FirstName = Console.ReadLine() ?? "";

            Console.Write("Enter last name: ");
            p.LastName = Console.ReadLine() ?? "";

            p.Height = ReadDouble("Enter height (cm): ");
            p.Weight = ReadDouble("Enter weight (kg): ");

            int sys = ReadInt("Enter systolic BP: ");
            int dia = ReadInt("Enter diastolic BP: ");

            Console.WriteLine();
            p.PrintBmiReport();

            Console.WriteLine();
            p.PrintBloodPressureReport(sys, dia);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (double.TryParse(input, out double val) && val > 0)
                    return val;

                Console.WriteLine("Invalid number. Please enter a positive value.");
            }
        }

        private static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int val) && val > 0)
                    return val;

                Console.WriteLine("Invalid number. Please enter a positive integer.");
            }
        }
    }
}