using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a random integer number, keep calm and just watch what a crazy thing will happen: ");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("You entered an even number");
            }
            else if(number % 2 == 1)
            {
                Console.WriteLine("You entered an odd number");
            }
            else
            {
                Console.WriteLine("IDK man. This is a life. Everything can be possible");
            }

            Console.WriteLine("Fantastic, right?");
            Console.ReadLine();
        }
    }
}
