using System;

class Program
{
    static void Main()
    {
        // Create a const variable
        const int myConst = 10;

        // Create a variable using the keyword "var"
        var myVar = "Hello, world!";

        // Chain two constructors together
        MyClass myObject = new MyClass("John");
        Console.WriteLine(myObject.Name);

        // Wait for user to press a key before closing the console
        Console.ReadKey();
    }
}

class MyClass
{
    public string Name { get; set; }

    // Constructor chaining
    public MyClass() : this("Default Name")
    {
    }

    public MyClass(string name)
    {
        Name = name;
    }
}
