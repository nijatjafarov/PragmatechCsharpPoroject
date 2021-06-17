using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your first name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string surname = Console.ReadLine();

        Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter your university name: ");
        string universityName = Console.ReadLine();

        Console.Write("Name: {0} \nSurname: {1} \nAge: {2} \nUniversity name: {3}",
            name, surname, age, universityName);
    }
}
