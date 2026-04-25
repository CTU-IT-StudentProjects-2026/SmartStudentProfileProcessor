using System;

namespace SmartStudentProfileProcessor
{
    class Program
    {
        // Global variables (available to all methods in this class)
        static string studentName;
        static int studentAge;
        static double assessmentScore;

        static void Main(string[] args)
        {
            Console.WriteLine("SMART STUDENT PROFILE PROCESSOR");
            Console.WriteLine("--------------------------------");

            CaptureStudentInfo();
            DisplayStudentProfile();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void CaptureStudentInfo()
        {
            Console.Write("Enter student name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter student age: ");
            studentAge = int.Parse(Console.ReadLine());

            Console.Write("Enter assessment score (0 - 100): ");
            assessmentScore = double.Parse(Console.ReadLine());
        }

        static string CalculateReadiness(double score)
        {
            if (score >= 50)
            {
                return "READY";
            }
            else
            {
                return "NOT READY";
            }
        }

        static string CalculateReadiness(int age, double score)
        {
            if (age >= 18 && score >= 50)
            {
                return "READY";
            }
            else
            {
                return "NOT READY";
            }
        }

        static void DisplayStudentProfile()
        {
            string readinessStatus = CalculateReadiness(studentAge, assessmentScore);

            Console.WriteLine("\nSTUDENT PROFILE SUMMARY");
            Console.WriteLine("------------------------");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Assessment Score: " + assessmentScore);
            Console.WriteLine("Readiness Status: " + readinessStatus);
        }
    }
}
