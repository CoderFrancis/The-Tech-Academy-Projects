using CallingMethods;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        MathOperations math = new MathOperations();

        // Call each method and display the returned integer
        int doubledNumber = math.DoubleNumber(input);
        Console.WriteLine($"Double: {doubledNumber}");

        int squaredNumber = math.SquareNumber(input);
        Console.WriteLine($"Square: {squaredNumber}");

        int factorialNumber = math.FactorialNumber(input);
        Console.WriteLine($"Factorial: {factorialNumber}");

        Console.ReadLine();
    }
}
