using System;

namespace SmartStudentProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Smart Student Profile Processor =====");

            // User Input
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            int age = GetValidAge();
            int marks = GetValidMarks();

            // Processing
            string readiness = CalculateReadiness(marks);

            // Output
            DisplayProfile(name, age, marks, readiness);

            Console.ReadLine();
        }

        // Method for Age Validation
        static int GetValidAge()
        {
            int age;
            Console.Write("Enter Age: ");
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Invalid age. Enter again: ");
            }
            return age;
        }

        // Method for Marks Validation
        static int GetValidMarks()
        {
            int marks;
            Console.Write("Enter Marks (0–100): ");
            while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
            {
                Console.Write("Invalid marks. Enter again: ");
            }
            return marks;
        }

        // Method: Calculate Readiness
        static string CalculateReadiness(int marks)
        {
            if (marks >= 75)
                return "High Readiness";
            else if (marks >= 50)
                return "Moderate Readiness";
            else
                return "Low Readiness";
        }

        // Method Overloading
        static string CalculateReadiness(double marks)
        {
            if (marks >= 75.0)
                return "High Readiness";
            else if (marks >= 50.0)
                return "Moderate Readiness";
            else
                return "Low Readiness";
        }

        // Display Method
        static void DisplayProfile(string name, int age, int marks, string readiness)
        {
            Console.WriteLine("\n===== Student Profile =====");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("Readiness Level: " + readiness);
        }
    }
}
