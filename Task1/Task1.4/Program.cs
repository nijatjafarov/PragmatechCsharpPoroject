using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your first name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your second name: ");
        string surname = Console.ReadLine();

        Console.Write("Hello, {0} {1}", name, surname);
    }
}