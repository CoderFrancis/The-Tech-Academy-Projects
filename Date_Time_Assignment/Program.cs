using System;

class Program
{
    static void Main()
    {
        // Print current date and time
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + currentDateTime);

        // Ask user for a number
        Console.Write("Enter a number: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        // Calculate future date and time
        DateTime futureDateTime = currentDateTime.AddHours(hours);

        // Print the exact time it will be in X hours
        Console.WriteLine("In {0} hours, it will be: {1}", hours, futureDateTime);

        // Wait for user to press a key before closing the console
        Console.ReadKey();
    }
}
