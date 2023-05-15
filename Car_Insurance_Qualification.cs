using System;

namespace CarInsuranceQualification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the age of the applicant
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Prompt for whether the applicant has had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Prompt for the number of speeding tickets of the applicant
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Evaluate the qualification rules
            bool qualifies = (age > 15) && (!hasDUI) && (speedingTickets <= 3);

            // Print the result of the qualification evaluation
            Console.WriteLine("Qualifies for car insurance: " + qualifies);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
