using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first letter: ");
        char letter1 = char.Parse(Console.ReadLine());

        Console.Write("Enter second letter: ");
        char letter2 = char.Parse(Console.ReadLine());

        Console.Write("Enter third letter: ");
        char letter3 = char.Parse(Console.ReadLine());


        Console.Write(letter3 + letter2 + letter1);
    }
}