using System;
using System.Linq;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many names do you want to add? ");
            int total = int.Parse(Console.ReadLine());

            while (total % 2 != 0)
            {
                Console.WriteLine("This is not an even number. Please, enter an even number");
                total = int.Parse(Console.ReadLine());
            }

            string[] names = new string[total];

            string[] teamA = new string[total / 2];
            string[] teamB = new string[total / 2];

            Random random = new Random();

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the name №{i + 1}: ");
                string name = Console.ReadLine();

                while (names.Contains(name) || name == "" || name == null)
                {
                    Console.Write($"You can't add this name anymore. Try another one: ");
                    name = Console.ReadLine();
                }

                names[i] = name;
            }

            Console.Write("First Team | ");
            for (int i = 0; i < names.Length / 2; i++)
            {
                string teamMember = names[random.Next(0, names.Length)];

                while (teamA.Contains(teamMember))
                {
                    teamMember = names[random.Next(0, names.Length)];
                }
                teamA[i] = teamMember;
                Console.Write($"{teamA[i]} ");
            }

            Console.Write("\nSecond Team | ");
            for (int i = 0; i < names.Length / 2; i++)
            {

                string teamMember = names[random.Next(0, names.Length)];

                while (teamA.Contains(teamMember) || teamB.Contains(teamMember))
                {
                    teamMember = names[random.Next(0, names.Length)];
                }
                teamB[i] = teamMember;
                Console.Write($"{teamB[i]} ");
            }
        }
    }
}
