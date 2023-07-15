using System;

namespace AbstractClassExample
{
    // Create an abstract class called Person
    abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method to say the person's name
        public abstract void SayName();
    }

    // Create a derived class called Employee, inheriting from Person
    class Employee : Person
    {
        // Implement the SayName() method from the base class
        public override void SayName()
        {
            string fullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Name: {fullName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and set its properties
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method on the Employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
