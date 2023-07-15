using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "John", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Williams" },
            new Employee { Id = 5, FirstName = "Emily", LastName = "Davis" },
            new Employee { Id = 6, FirstName = "David", LastName = "Brown" },
            new Employee { Id = 7, FirstName = "Sarah", LastName = "Miller" },
            new Employee { Id = 8, FirstName = "Joe", LastName = "Wilson" },
            new Employee { Id = 9, FirstName = "Michael", LastName = "Anderson" },
            new Employee { Id = 10, FirstName = "Olivia", LastName = "Taylor" }
        };

        // Create a new list of employees with the first name "Joe" using a foreach loop
        List<Employee> joes = new List<Employee>();
        foreach (Employee emp in employees)
        {
            if (emp.FirstName == "Joe")
            {
                joes.Add(emp);
            }
        }

        // Create a new list of employees with the first name "Joe" using a lambda expression
        List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

        // Create a list of employees with an Id number greater than 5 using a lambda expression
        List<Employee> highIdEmployees = employees.Where(emp => emp.Id > 5).ToList();

        // Print the results
        Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
        foreach (Employee emp in joes)
        {
            Console.WriteLine($"Id: {emp.Id}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
        }

        Console.WriteLine();

        Console.WriteLine("Employees with the first name 'Joe' (lambda expression):");
        foreach (Employee emp in joesLambda)
        {
            Console.WriteLine($"Id: {emp.Id}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
        }

        Console.WriteLine();

        Console.WriteLine("Employees with an Id number greater than 5 (lambda expression):");
        foreach (Employee emp in highIdEmployees)
        {
            Console.WriteLine($"Id: {emp.Id}, First Name: {emp.FirstName}, Last Name: {emp.LastName}");
            Console.ReadLine();
        }
    }
}
