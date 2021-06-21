using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            do
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);

            Console.WriteLine("Sum of entered numbers is: {0}", sum);
        }
    }
}
