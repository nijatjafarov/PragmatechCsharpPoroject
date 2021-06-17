using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Your number is greater than 0");
            }
            else if (number < 0)
            {
                Console.WriteLine("Your number is less than 0");
            }
            else
            {
                Console.WriteLine("Your number is 0");
            }
        }
    }
}
