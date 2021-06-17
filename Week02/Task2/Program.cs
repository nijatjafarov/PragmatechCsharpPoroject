using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            if(firstNum > secondNum)
            {
                Console.WriteLine("First number is greater than the second one");
            }
            else if(secondNum > firstNum)
            {
                Console.WriteLine("Second number is greater than the first one");
            }
            else if(firstNum == secondNum)
            {
                Console.WriteLine("These numbers are equal");
            }
            else
            {
                Console.WriteLine("Man, you are genius. You did something crazy or impossible");
            }
        }
    }
}
