using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;

            Console.Write("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i < secondNum + 1; i++)
            {
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }
    }
}
