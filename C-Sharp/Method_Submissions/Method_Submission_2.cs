using System;

namespace MathOperationProgram
{
    // Create a class called MathOperation
    class MathOperation
    {
        // Void method that takes two integers as parameters
        public void PerformOperation(int number1, int number2)
        {
            // Example math operation: Multiply the first number by 2
            int result = number1 * 2;

            // Display the second number to the screen
            Console.WriteLine("Second Number: " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOperation = new MathOperation();

            // Call the PerformOperation method, passing in two numbers
            mathOperation.PerformOperation(5, 10);

            // Call the PerformOperation method, specifying the parameters by name
            mathOperation.PerformOperation(number1: 7, number2: 20);

            Console.ReadLine();
        }
    }
}
