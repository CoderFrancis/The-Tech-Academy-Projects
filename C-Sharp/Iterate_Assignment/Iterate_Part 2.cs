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
            while (true)
            {
                for (int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] += userInput;
                }
            }

            // The code beyond this point will not be reached due to the infinite loop
        }
    }
}
