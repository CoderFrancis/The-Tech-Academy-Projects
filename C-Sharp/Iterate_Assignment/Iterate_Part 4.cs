using System;
using System.Collections.Generic;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings
            List<string> stringList = new List<string> { "apple", "banana", "orange", "grape", "melon" };

            // Ask the user to input text to search for in the list
            Console.WriteLine("Enter text to search for:");
            string searchText = Console.ReadLine();

            // Loop to iterate through the list and find the matching text
            bool foundMatch = false;
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i] == searchText)
                {
                    Console.WriteLine("Matching text found at index: " + i);
                    foundMatch = true;
                    break; // Stop the loop once a match is found
                }
            }

            // Check if the user's input is not on the list
            if (!foundMatch)
            {
                Console.WriteLine("Input is not on the list.");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
