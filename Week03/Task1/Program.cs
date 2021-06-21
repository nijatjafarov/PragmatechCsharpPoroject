using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNum = 0;
            int sum = evenNum;

            while (evenNum < 100)
            {
                evenNum += 2;
                sum += evenNum;
                Console.WriteLine($"Even number: {evenNum} | Sum till this number: {sum}");
            }
            Console.WriteLine($"\nFinal sum is {sum}");
        }
    }
}
