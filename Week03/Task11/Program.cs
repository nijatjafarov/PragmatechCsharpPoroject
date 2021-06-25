using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bele etme sebebim proqramin biraz daha yungul
            islemesini temin etmekdir, cut ededler onsuzda sade olmadigi ucun tekler uzerinden yoxladim ve
            ilk basda 2 ededini mexaniki formada daxil etdim*/

            bool isPrime = true;

            Console.WriteLine(2);
            for (int i = 3; i < 100; i += 2)
            {
                for (int j = 3; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{i}");
                }
                isPrime = true;
            }
        }
    }
}
