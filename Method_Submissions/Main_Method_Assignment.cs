using System;

namespace MathOperationsProgram
{
    // Create a class called MathOperations
    class MathOperations
    {
        // Method that takes an integer, performs a math operation, and returns the result as an integer
        public int PerformOperation(int number)
        {
            // Example math operation: Multiply the number by 2
            int result = number * 2;
            return result;
        }

        // Method that takes a decimal, performs a different math operation, and returns the result as an integer
        public int PerformOperation(decimal number)
        {
            // Example math operation: Divide the number by 2 and round down
            int result = (int)(number / 2);
            return result;
        }

        // Method that takes a string, converts it to an integer, performs a different math operation, and returns the result as an integer
        public int PerformOperation(string input)
        {
            // Convert the string to an integer
            int number = Convert.ToInt32(input);

            // Example math operation: Subtract 5 from the number
            int result = number - 5;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the PerformOperation method with an integer parameter
            int result1 = mathOperations.PerformOperation(10);
            Console.WriteLine("Result 1: " + result1);

            // Call the PerformOperation method with a decimal parameter
            int result2 = mathOperations.PerformOperation(7.5m);
            Console.WriteLine("Result 2: " + result2);

            // Call the PerformOperation method with a string parameter
            int result3 = mathOperations.PerformOperation("15");
            Console.WriteLine("Result 3: " + result3);

            Console.ReadLine();
        }
    }
}
