using System;
using System.Collections;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList uzvler = new ArrayList();

            Console.WriteLine("Sport komplekse qeydiyyat sistemi\n");

        Tekrar:
            Console.WriteLine("Edeceyiniz emeliyyati secin:");

            Console.WriteLine("1-Uzv daxil edin");
            Console.WriteLine("2-Uzvu qeydiyyatdan silin");
            Console.WriteLine("3-Uzvlerin siyahisini gorun");
            Console.WriteLine("4-Uzvlerin siyahisini ters cevirin");
            Console.WriteLine("5-Uzvlerin qeydiyyatda olub-olmamasini yoxlayin");
            Console.WriteLine("6-Uzvlerin siyahisini basdan sona siralayin");
            Console.WriteLine("7-Butun uzvlerin qeydiyyatini silin");
            Console.WriteLine("8-Sport komplekse qeydiyyat sisteminden cixin\n");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("Daxil edilecek uzv sayini bildirin: ");
                    int uzvSayi = int.Parse(Console.ReadLine());

                    for (int i = 0; i < uzvSayi; i++)
                    {
                        Console.Write("Uzv {0}: ", i + 1);
                        string uzv = Console.ReadLine();

                        uzvler.Add(uzv);
                    }
                    Console.WriteLine("\n");
                    goto Tekrar;

                case 2:
                    Console.Write("Uzvler | ");

                    for (int i = 0; i < uzvler.Count; i++)
                    {
                        Console.Write("{0} ", uzvler[i]);
                    }

                    Console.Write("\n Silmek istediyiniz uzvun adini daxil edin: ");

                    string silinecekUzv = Console.ReadLine();

                    while (!uzvler.Contains(silinecekUzv))
                    {
                        Console.Write("Bele bir uzv movcud deyil. Yeniden daxil edin: ");
                        silinecekUzv = Console.ReadLine();
                    }

                    uzvler.Remove(silinecekUzv);
                    Console.WriteLine("\n");
                    goto Tekrar;

                case 3:
                    Console.Write("Uzvlerin siyahisi | ");

                    for (int i = 0; i < uzvler.Count; i++)
                    {
                        Console.Write("{0} ", uzvler[i]);
                    }
                    Console.WriteLine("\n");
                    goto Tekrar;

                case 4:
                    uzvler.Reverse();
                    Console.Write("Uzvlerin ters cevrilmish siyahisi | ");

                    for (int i = 0; i < uzvler.Count; i++)
                    {
                        Console.Write("{0} ", uzvler[i]);
                    }
                    uzvler.Reverse();
                    Console.WriteLine("\n");
                    goto Tekrar;

                case 5:
                    Console.Write("Ad daxil edin: ");
                    string yoxlanilacaqUzv = Console.ReadLine();
                    bool movcuddur = uzvler.Contains(yoxlanilacaqUzv);

                    if (movcuddur)
                    {
                        Console.WriteLine("Daxil etdiyiniz ad siyahida movcuddur");
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz ad siyahida movcud deyil");
                    }
                    Console.WriteLine("\n");
                    goto Tekrar;

                case 6:
                    uzvler.Sort();
                    Console.Write("Uzvlerin elifba sirasina gore siralanmis siyahisi | ");

                    for (int i = 0; i < uzvler.Count; i++)
                    {
                        Console.Write("{0} ", uzvler[i]);
                    }
                    Console.WriteLine("\n");
                    goto Tekrar;

                case 7:
                    uzvler.Clear();
                    Console.WriteLine("Butun uzvlerin qeydiyyati silindi\n");

                    goto Tekrar;

                case 8:
                    break;

                default:
                    break;
            }
        }
    }
}
