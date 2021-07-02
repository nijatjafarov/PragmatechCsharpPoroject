using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daxil etmek istediyiniz ededlerin sayi: ");
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i+1}. ededi daxil edin: ");
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
                if (number % 2 == 1)
                {
                    ++count;
                }
            }

            Console.WriteLine(count);

            int[] oddNums = new int[count];
            int j = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddNums[j] = numbers[i];
                    ++j;
                }
            }

            Console.Write("Siyahinizdaki tek ededler | ");
            for (int i = 0; i < oddNums.Length; i++)
            {
                Console.Write($"{oddNums[i]} ");
            }
        }
    }
}
