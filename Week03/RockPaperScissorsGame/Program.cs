using System;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] secimler = new string[3] { "das", "kagiz", "qayci" };
            Random random = new Random();

            int istifadeciBali = 0;
            int komputerBali = 0;

            Console.WriteLine("Das, kagiz, qayci oyunu!");

            while (istifadeciBali < 3 && komputerBali < 3)
            {
                Console.WriteLine();
                Console.Write("Das, kagiz ve qaycidan birini secin: ");
                string istifadeci = Console.ReadLine().ToLower();
                string komputer = secimler[random.Next(0, 3)];


                switch (istifadeci)
                {
                    case "das":
                        if (komputer == "kagiz")
                        {
                            komputerBali += 1;
                        }
                        else if (komputer == "qayci")
                        {
                            istifadeciBali += 1;
                        }
                        Console.WriteLine("Komputerin secimi: {0}", char.ToUpper(komputer[0]) + komputer.Substring(1));
                        break;
                    case "kagiz":
                        if (komputer == "qayci")
                        {
                            komputerBali += 1;
                        }
                        else if (komputer == "das")
                        {
                            istifadeciBali += 1;
                        }
                        Console.WriteLine("Komputerin secimi: {0}", char.ToUpper(komputer[0]) + komputer.Substring(1));
                        break;
                    case "qayci":
                        if (komputer == "das")
                        {
                            komputerBali += 1;
                        }
                        else if (komputer == "kagiz")
                        {
                            istifadeciBali += 1;
                        }
                        Console.WriteLine("Komputerin secimi: {0}", char.ToUpper(komputer[0]) + komputer.Substring(1));
                        break;
                    default:
                        Console.WriteLine("Yalnis secim daxil etmisiniz");
                        break;
                }
                Console.WriteLine("Siz: {0} | Komputer: {1}", istifadeciBali, komputerBali);
            }

            if (komputerBali >= 3)
            {
                Console.WriteLine("Komputer qalib geldi!");
            }
            else if (istifadeciBali >= 3)
            {
                Console.WriteLine("Tebrikler. Siz qalib geldiniz!");
            }
        }
    }
}
