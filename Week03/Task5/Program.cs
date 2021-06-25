using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many names do you want to add? ");
            int num = int.Parse(Console.ReadLine());

            string[] names = new string[num];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter the {0}th name: ", i + 1);
                names[i] = Console.ReadLine();
            }

            Console.Write("Which name do you want to choose? ");
            string name = Console.ReadLine();
            int total = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    total += 1;
                }
            }
            Console.WriteLine("Chosen name: {0} | You entered this name {1} times", name, total);
        }
    }
}
