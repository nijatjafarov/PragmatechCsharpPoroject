﻿using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Multiplication by {i}");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine();
            }
        }
    }
}
