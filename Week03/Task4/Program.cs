using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            while (number == 0)
            {
                Console.Write("Number can't be zero. Try again: ");
                number = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < number + 1; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");

        }
    }
}
