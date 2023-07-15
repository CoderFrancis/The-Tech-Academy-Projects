using System;

namespace InterfaceExample
{
    // Create an interface called IQuittable
    interface IQuittable
    {
        // Define a void method called Quit()
        void Quit();
    }

    // Create a class called Employee that inherits from IQuittable
    class Employee : IQuittable
    {
        // Implement the Quit() method from the interface
        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuittable using polymorphism
            IQuittable quittable = new Employee();

            // Call the Quit() method on the object
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
