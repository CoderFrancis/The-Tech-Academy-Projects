using System;

namespace InheritanceExample
{
    // Create a base class called Person
    class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method to say the person's name
        public void SayName()
        {
            string fullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Name: {fullName}");
        }
    }

    // Create a derived class called Employee, inheriting from Person
    class Employee : Person
    {
        // Property specific to Employee
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            // Call the SayName() method on the Employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}

