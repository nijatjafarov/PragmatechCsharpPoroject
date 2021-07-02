using System;
using System.Collections;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3
            string[] array1 = new string[5];
            string[] array2 = new string[5];

            int count = 0;

            ArrayList ortaq = new ArrayList();

            Console.WriteLine("İlk siyahi");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"İlk siyahi ucun {i + 1}. element daxil edin: ");
                array1[i] = Console.ReadLine();
            }

            Console.WriteLine("\nİkinci siyahi");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"İkinci siyahi ucun {i + 1}. element daxil edin: ");
                string element = Console.ReadLine();
                if (array1.Contains(element))
                {
                    count += 1;
                    ortaq.Add(element);
                }
            }

            Console.Write("\nOrtaq elementler | ");
            for (int i = 0; i < ortaq.Count; i++)
            {
                Console.Write($"{ortaq[i]} ");
            }
            Console.WriteLine($"\nOrtaq elementlerin sayi {count}");

        }
    }
}
