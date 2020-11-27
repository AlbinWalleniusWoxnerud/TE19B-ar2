using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace All_will_change
{
    class Program
    {
        static string[] tempinfo = File.ReadAllLines("bord.txt");
        static int[] guests = File.ReadAllLines("guests.txt");
        static void slee(string inp)
        {
            for (int i = 0; i <= inp.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(20);
                Console.Write(inp.Substring(i, 1));
            }
            if (inp.Length <= 10) Thread.Sleep(500);
            Console.WriteLine();
        }
        static void Main()
        {
            slee("Detta är Centralrestaurangens bordshanterare");
            choise();
        }
        static void choise()
        {
            Console.WriteLine();
            slee("Välj ett alternativ\n1.Visa alla bord\n2.Lägg till / ändra bordsinformation\n3.Markera att ett bord är tomt\n4.Töm alla bord\n5.Avsluta programmet");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    allabord();
                    break;
                case 2:
                    bordinfo();
                    break;
                case 3:
                    bordtomt();
                    break;
                case 4:
                    empty();
                    break;

                case 5:
                    break;
            }
        }

        static void allabord()
        {
            Console.WriteLine();
            string[] getbordinfo = File.ReadAllLines("bord.txt");
            foreach (string bord in getbordinfo)
            {
                Console.WriteLine(bord);
            }
            int sum = guests.Sum();
            Console.WriteLine($"Totalt antal gäster: {sum}");
            choise();
        }

        static void bordinfo()
        {
            Console.WriteLine();
            slee("Vilket bordsnummer vill du lägga till/ändra informationen för?");
            int a = int.Parse(Console.ReadLine());
            a -= 1;
            slee("Skriv in bordets namn");
            string b = Console.ReadLine();
            slee("Hur många gäster finns vid bordet?");
            guests[a] = int.Parse(Console.ReadLine());
            tempinfo[a] = ($"Bord {a + 1} - Namn: {b}, antal gäster: {guests[a]}");
            update();
        }

        static void bordtomt()
        {
            Console.WriteLine();
            slee("Vilket bordsnummer vill du markera som tomt?");
            int a = int.Parse(Console.ReadLine());
            a -= 1;
            tempinfo[a] = ($"Bord {a + 1} - Inga gäster");
            guests[a] = 0;
            update();
        }

        static void update()
        {
            File.WriteAllLines("bord.txt", tempinfo);
            choise();
        }

        static void empty()
        {
            for (int i = 0; i < tempinfo.Length; i++)
            {
                tempinfo[i] = ($"Bord {i + 1} - Inga gäster");
            }
            File.WriteAllLines("bord.txt", tempinfo);
            choise();
        }

    }
}