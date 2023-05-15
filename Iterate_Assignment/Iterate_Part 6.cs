using System;
using System.Collections.Generic;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings with at least two identical strings
            List<string> stringList = new List<string> { "A", "B", "C", "D", "C" };

            // Create a HashSet to keep track of unique strings
            HashSet<string> uniqueStrings = new HashSet<string>();

            // Loop through each item in the list using a foreach loop
            foreach (string item in stringList)
            {
                // Check if the item has already appeared in the list
                if (uniqueStrings.Contains(item))
                {
                    Console.WriteLine($"String '{item}' has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine($"String '{item}' is a new entry.");
                    uniqueStrings.Add(item); // Add the string to the HashSet
                }
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
