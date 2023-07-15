using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print "The Tech Academy"
            Console.WriteLine("The Tech Academy");

            // Print "Student Daily Report"
            Console.WriteLine("Student Daily Report");

            // Prompt for and save name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Prompt for and save course name
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Prompt for and save page number
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Prompt for and save if help is needed
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Prompt for and save positive experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Prompt for and save other feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            // Prompt for and save study hours
            Console.WriteLine("How many hours did you study today?");
            float studyHours = Convert.ToSingle(Console.ReadLine());

            // Print final message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
