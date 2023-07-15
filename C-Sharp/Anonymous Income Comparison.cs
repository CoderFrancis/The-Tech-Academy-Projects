using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print "Anonymous Income Comparison Program"
            Console.WriteLine("Anonymous Income Comparison Program");

            // Prompt for and get details for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate:");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week:");
            int hoursWorkedPerWeek1 = Convert.ToInt32(Console.ReadLine());

            // Prompt for and get details for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate:");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week:");
            int hoursWorkedPerWeek2 = Convert.ToInt32(Console.ReadLine());

            // Calculate annual salary for Person 1 (assuming 52 weeks in a year)
            decimal annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;

            // Calculate annual salary for Person 2 (assuming 52 weeks in a year)
            decimal annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            // Print annual salaries for Person 1 and Person 2
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

            // Check if Person 1 makes more money than Person 2
            bool person1MakesMore = annualSalary1 > annualSalary2;

            // Print whether Person 1 makes more money than Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2? " + person1MakesMore);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}

