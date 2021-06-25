using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.WriteLine(alphabet[i]);
            }

            Console.WriteLine("Vurma cedveli");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"\n{i} ile vurma, ingilisce yazarsan");

                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}
