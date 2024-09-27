using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World and People!");
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
