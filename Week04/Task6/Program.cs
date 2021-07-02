using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //First version
            //Console.Write("How many numbers do you want to add to array? ");
            //int length = int.Parse(Console.ReadLine());

            //int[] nums = new int[length];
            //int min;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"Add {i + 1}. number: ");
            //    nums[i] = int.Parse(Console.ReadLine());
            //}

            //min = nums[0];

            //Console.Write("Your array | ");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"{nums[i]} ");
            //    if (min > nums[i])
            //    {
            //        min = nums[i];
            //    }
            //}

            //Console.WriteLine($"Minimum number in array is {min}");




            //Second version
            Console.Write("How many numbers do you want to add to array? ");
            int length = int.Parse(Console.ReadLine());

            int[] nums = new int[length];
            int min;


            Console.Write($"Add 1. number: ");
            nums[0] = int.Parse(Console.ReadLine());
            min = nums[0];


            for (int i = 1; i < nums.Length; i++)
            {
                Console.Write($"Add {i + 1}. number: ");
                int currentNum = int.Parse(Console.ReadLine());

                nums[i] = currentNum;

                if (min > currentNum)
                {
                    min = currentNum;
                }
            }

            Console.Write("Your array | ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }

            Console.WriteLine($"Minimum number in array is {min}");

        }
    }
}
