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
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            // Loop with comparison using the "<=" operator
            int counter = 0;
            while (counter <= stringArray.Length - 1)
            {
                Console.WriteLine(stringArray[counter]);
                counter++;
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
