using System;

namespace CSProjectGroup1
{
    public class Patient
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public double Weight { get; set; }  // kg
        public double Height { get; set; }  // cm

        public string FullName => $"{FirstName} {LastName}";

        public double CalculateBmi()
        {
            double meters = Height / 100.0;
            return Weight / (meters * meters);
        }

        public string GetBmiCategory(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25) return "Normal weight";
            if (bmi < 30) return "Overweight";
            return "Obese";
        }

        public void PrintBmiReport()
        {
            double bmi = CalculateBmi();
            Console.WriteLine("===== BMI REPORT =====");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"BMI: {bmi:F1}");
            Console.WriteLine($"Status: {GetBmiCategory(bmi)}");
        }

        public string GetBloodPressureCategory(int sys, int dia)
        {
            if (sys < 120 && dia < 80) return "Normal BP";
            if (sys >= 120 && sys <= 129 && dia < 80) return "Elevated BP";
            if ((sys >= 130 && sys <= 139) || (dia >= 80 && dia <= 89)) return "Stage 1 Hypertension";
            if (sys >= 140 || dia >= 90) return "Stage 2 Hypertension";
            return "Unclassified";
        }

        public void PrintBloodPressureReport(int sys, int dia)
        {
            Console.WriteLine("===== BLOOD PRESSURE REPORT =====");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"BP: {sys}/{dia}");
            Console.WriteLine($"Category: {GetBloodPressureCategory(sys, dia)}");
        }
    }
}