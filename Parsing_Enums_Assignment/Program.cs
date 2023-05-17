using System;

// Define an enum for the days of the week
enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        try
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week:");
            string userInput = Console.ReadLine();

            // Convert the user input to the enum type
            DayOfWeek currentDay;
            if (Enum.TryParse(userInput, true, out currentDay))
            {
                // Assign the value to a variable of the enum data type
                Console.WriteLine("Current day: " + currentDay);
            }
            else
            {
                // Print an error message if the user input is not a valid day of the week
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
        catch (Exception ex)
        {
            // Handle any exception that occurs and print the error message
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.ReadLine();
    }
}
