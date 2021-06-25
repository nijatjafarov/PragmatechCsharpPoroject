using System;
using System.Linq;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            bool containVowel = false;
            int countVowels = 0;


            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    containVowel = true;
                    countVowels += 1;
                }
            }

            if (containVowel)
            {
                Console.WriteLine($"Word contains vowels {countVowels} times");
            }
            else
            {
                Console.WriteLine($"Word doesn't contain any vowel");
            }
        }
    }
}
