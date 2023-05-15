using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for the package weight
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine(); // Wait for user input before closing the console window
                return; // End the program
            }

            // Prompt for the package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt for the package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt for the package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the dimensions total
            decimal dimensionsTotal = width + height + length;

            // Check if the dimensions total exceeds 50
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine(); // Wait for user input before closing the console window
                return; // End the program
            }

            // Calculate the quote
            decimal quote = (dimensionsTotal * weight) / 100;

            // Display the quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
