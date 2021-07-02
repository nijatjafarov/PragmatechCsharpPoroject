using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //First version
            //int[] randomNums = new int[5];
            //int[] reversedNums = new int[randomNums.Length];

            //Random random = new Random();

            //Console.Write("Array of random numbers | ");
            //for (int i = 0; i < randomNums.Length; i++)
            //{
            //    randomNums[i] = random.Next(100);
            //    Console.Write($"{randomNums[i]} ");
            //}

            //Console.Write("\n\nReversed version of the array | ");
            //for (int i = 0; i < reversedNums.Length; i++)
            //{
            //    reversedNums[i] = randomNums[randomNums.Length - 1 - i];
            //    Console.Write($"{reversedNums[i]} ");
            //}


            //Second version
            int[] randomNums = new int[5];

            Random random = new Random();

            Console.Write("Array of random numbers | ");
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = random.Next(100);
                Console.Write($"{randomNums[i]} ");
            }

            int[] reversedNums = (int[])randomNums.Clone();
            reversedNums.Reverse();

            Console.Write("\n\nReversed version of the array | ");
            for (int i = 0; i < reversedNums.Length; i++)
            {
                reversedNums[i] = randomNums[randomNums.Length - 1 - i];
                Console.Write($"{reversedNums[i]} ");
            }
        }
    }
}
