using System;

namespace UserInputCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number and convert it to a decimal data type
            Console.WriteLine("Enter a number:");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());

            // Multiply the user input by 50 and print the result
            decimal multipliedResult = userInput * 50;
            Console.WriteLine("Result of multiplying by 50: " + multipliedResult);

            // Add 25 to the user input and print the result
            decimal addedResult = userInput + 25;
            Console.WriteLine("Result of adding 25: " + addedResult);

            // Divide the user input by 12.5 and print the result
            decimal dividedResult = userInput / 12.5m; // The 'm' suffix denotes a decimal literal
            Console.WriteLine("Result of dividing by 12.5: " + dividedResult);

            // Check if the user input is greater than 50 and print the true/false result
            bool isGreaterThan50 = userInput > 50;
            Console.WriteLine("Is the input greater than 50? " + isGreaterThan50);

            // Divide the user input by 7 and print the remainder
            decimal remainder = userInput % 7;
            Console.WriteLine("Remainder after dividing by 7: " + remainder);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
