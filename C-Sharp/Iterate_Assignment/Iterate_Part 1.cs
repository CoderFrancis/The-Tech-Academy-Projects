using System;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = new string[5];

            // Ask the user to input some text
            Console.WriteLine("Enter some text:");
            string userInput = Console.ReadLine();

            // Loop to add the user's text input to each string in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            // Loop to print each string in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
