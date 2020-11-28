using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Project_2
{
    class Program
    {
        static int bordsnr = 8;
        static string[] tempinfo = new string[bordsnr];
        static int[] guests = new int[bordsnr];
        static string[] tempguests = new string[bordsnr];
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
            check();
            choise();
        }

        static void check()
        {
            if (File.Exists("bord.txt") && File.Exists("guests.txt"))
            {
                tempinfo = File.ReadAllLines("bord.txt");
                string[] tempguests = File.ReadAllLines("guests.txt");
                for (int i = 0; i < tempguests.Length; i++)
                {
                    guests[i] = int.Parse(tempguests[i]);
                }
                slee("Bordsinformation kan läsas in från fil");
                slee("Vill du läsa in filen? J/N");
                string a = Console.ReadLine().ToLower();
                if (a != "j") { slee("Ny information skapades"); empty(); }
                else choise();
            }
            else
            {
                slee("Fil med bordsinformation hittades ej, ny information skapades");
                empty();
            }
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
                    System.Environment.Exit(0);
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
            tempguests[a] = ($"{guests[a]}");
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
            File.WriteAllLines("guests.txt", tempguests);
            File.WriteAllLines("bord.txt", tempinfo);
            choise();
        }

        static void empty()
        {
            for (int i = 0; i < tempinfo.Length; i++)
            {
                tempguests[i] = "0";
            }
            File.WriteAllLines("guests.txt", tempguests);

            for (int i = 0; i < tempinfo.Length; i++)
            {
                tempinfo[i] = ($"Bord {i + 1} - Inga gäster");
            }
            File.WriteAllLines("bord.txt", tempinfo);
            choise();
        }

    }
}