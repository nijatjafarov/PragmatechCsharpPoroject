using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 10);
            int guessedNum;
            int totalGuesses = 0;

            do
            {
                Console.Write("Try to guess the random number which computer selected: ");
                guessedNum = int.Parse(Console.ReadLine());
                totalGuesses += 1;

            } while (totalGuesses < 5 && randomNum != guessedNum);

            if (totalGuesses >= 5)
            {
                Console.WriteLine("You used all of your chances. Right answer was {0}", randomNum);
            }
            else if (randomNum == guessedNum)
            {
                Console.WriteLine("Congratulations! You found out the number");
            }
        }
    }
}
