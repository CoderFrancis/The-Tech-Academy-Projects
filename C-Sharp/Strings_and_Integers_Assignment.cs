using System;
using System.Collections.Generic;

namespace DivideList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Ask the user for a number to divide each number in the list by
                Console.Write("Enter a number to divide each number in the list: ");
                int divisor = int.Parse(Console.ReadLine());

                // Create a loop to divide each integer in the list and display the result
                for (int i = 0; i < numbers.Count; i++)
                {
                    int result = numbers[i] / divisor;
                    Console.WriteLine($"Result: {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution continued after the try/catch block.");
            }
            Console.ReadLine();
        }
    }
}
