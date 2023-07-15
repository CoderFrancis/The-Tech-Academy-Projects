using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Orange" };

            // Ask the user to select an index of the array
            Console.WriteLine("Select an index of the string array (0, 1, or 2):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);
            }
            else
            {
                // Display a message when the user selects an invalid index
                Console.WriteLine("Invalid index!");
            }

            Console.WriteLine();

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30 };

            // Ask the user to select an index of the array
            Console.WriteLine("Select an index of the integer array (0, 1, or 2):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine("Integer at index " + intIndex + ": " + intArray[intIndex]);
            }
            else
            {
                // Display a message when the user selects an invalid index
                Console.WriteLine("Invalid index!");
            }

            Console.WriteLine();

            // Create a list of strings
            List<string> stringList = new List<string> { "Cat", "Dog", "Bird" };

            // Ask the user to select an index of the list
            Console.WriteLine("Select an index of the string list (0, 1, or 2):");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the content at the selected index
                Console.WriteLine("Content at index " + listIndex + ": " + stringList[listIndex]);
            }
            else
            {
                // Display a message when the user selects an invalid index
                Console.WriteLine("Invalid index!");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
