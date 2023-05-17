using System;

namespace MathProgram
{
    // Create a class called MathOperations
    class MathOperations
    {
        // Void method that outputs an integer
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine("Result: " + result);
        }

        // Method with output parameters
        public void MultiplyByTwo(int number, out int result)
        {
            result = number * 2;
        }

        // Method overloading
        public void MultiplyByTwo(double number)
        {
            double result = number * 2;
            Console.WriteLine("Result: " + result);
        }
    }

    // Declare a static class
    static class StaticClass
    {
        // Static method
        public static void PrintMessage()
        {
            Console.WriteLine("This is a static method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Have the user enter a number
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the DivideByTwo method on the entered number
            mathOperations.DivideByTwo(userInput);

            // Method with output parameters
            int outputResult;
            mathOperations.MultiplyByTwo(userInput, out outputResult);
            Console.WriteLine("Output Result: " + outputResult);

            // Method overloading
            double doubleNumber = 3.14;
            mathOperations.MultiplyByTwo(doubleNumber);

            // Call the static method from the StaticClass
            StaticClass.PrintMessage();

            Console.ReadLine();
        }
    }
}
