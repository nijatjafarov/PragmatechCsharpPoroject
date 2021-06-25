using System;
using System.Linq;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNums = new int[10];
            int count = 0;
            bool zero = false;

            Random random = new Random();

            Console.Write("Array of random numbers | ");
            for (int i = 0; i < randomNums.Length; i++)
            {
                int randomNum = random.Next(0, randomNums.Length);


                while ((randomNums.Contains(randomNum) && randomNum != 0) || (randomNum == 0 && zero))
                {

                    randomNum = random.Next(0, randomNums.Length);
                    count += 1;
                }

                if (randomNum == 0)
                {
                    zero = true;
                }

                randomNums[i] = randomNum;
                Console.Write($"{randomNums[i]} ");
            }
            Console.Write($"Total dublicates: {count}");
        }
    }
}
