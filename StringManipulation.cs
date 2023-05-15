using System;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string string1 = "Hello";
            string string2 = " ";
            string string3 = "world!";
            string concatenatedString = string1 + string2 + string3;

            Console.WriteLine("Concatenated string: " + concatenatedString);
            Console.WriteLine();

            // Converting a string to uppercase
            string lowercaseString = "hello world!";
            string uppercaseString = lowercaseString.ToUpper();

            Console.WriteLine("Uppercase string: " + uppercaseString);
            Console.WriteLine();

            // Creating a StringBuilder and building a paragraph of text
            StringBuilder paragraphBuilder = new StringBuilder();

            paragraphBuilder.Append("This is the first sentence. ");
            paragraphBuilder.Append("This is the second sentence. ");
            paragraphBuilder.Append("This is the third sentence.");

            string paragraph = paragraphBuilder.ToString();

            Console.WriteLine("Paragraph: " + paragraph);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}

