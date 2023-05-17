using System;

namespace MathOperationProgram
{
    // Create a class called MathOperation
    class MathOperation
    {
        // Method that takes two integers as parameters, with the second one being optional
        public int PerformOperation(int number1, int number2 = 0)
        {
            // Example math operation: Multiply the first number by the second number
            int result = number1 * number2;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOperation = new MathOperation();

            // Ask the user to input two numbers
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number (optional): ");
            string input = Console.ReadLine();

            // Call the PerformOperation method with the entered numbers
            int result;
            if (!string.IsNullOrEmpty(input))
            {
                // If the second number is provided by the user
                int number2 = Convert.ToInt32(input);
                result = mathOperation.PerformOperation(number1, number2);
            }
            else
            {
                // If the second number is not provided by the user
                result = mathOperation.PerformOperation(number1);
            }

            // Display the result
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}

