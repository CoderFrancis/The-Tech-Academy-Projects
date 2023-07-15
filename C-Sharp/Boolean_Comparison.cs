using System;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            Console.WriteLine("Boolean comparison using a while statement:");

            int number1 = 5;
            int number2 = 10;

            // Print whether number1 is less than number2 using a while loop
            while (number1 < number2)
            {
                Console.WriteLine(number1 + " is less than " + number2);
                number1++;
            }

            Console.WriteLine();

            // Boolean comparison using a do-while statement
            Console.WriteLine("Boolean comparison using a do-while statement:");

            int number3 = 15;
            int number4 = 10;

            // Print whether number3 is greater than number4 using a do-while loop
            do
            {
                Console.WriteLine(number3 + " is greater than " + number4);
                number3--;
            }
            while (number3 > number4);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
