using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //First version
            //int[] randomNums = new int[5];
            //int sum = 0;

            //Random random = new Random();

            //Console.Write("Array of random numbers | ");
            //for (int i = 0; i < randomNums.Length; i++)
            //{
            //    randomNums[i] = random.Next(100);
            //    Console.Write($"{randomNums[i]} ");
            //    sum += randomNums[i];
            //}

            //Console.Write($"\n\nSum of elements of array is {sum} ");




            //Second version
            int[] randomNums = new int[5];

            Random random = new Random();

            Console.Write("Array of random numbers | ");
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = random.Next(100);
                Console.Write($"{randomNums[i]} ");
            }

            Console.Write($"\n\nSum of elements of array is {randomNums.Sum()} ");

        }
    }
}
