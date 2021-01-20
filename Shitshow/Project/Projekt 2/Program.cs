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
        static string baseName = "Inga gäster";
        static void slee(string inp)
        {
            for (int i = 0; i <= inp.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1);
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
            if (File.Exists("bord.txt"))
            {
                tempinfo = File.ReadAllLines("bord.txt");
                slee("Bordsinformation kan läsas in från fil");
                bool choise1 = true;
                while (choise1)
                {
                    slee("Vill du läsa in filen? J/N");
                    string a = Console.ReadLine().ToLower();
                    if (a == "n") { slee("Ny information skapades"); choise1 = false; empty(); }
                    if (a == "j") { choise1 = false; choise(); }
                }
            }
            else
            {
                slee("Fil med bordsinformation hittades ej, ny information skapades");
                empty();
            }
        }
        static void choise()
        {

            bool choise3 = false;
            int a = 0;
            while (!choise3)
            {
                bool choise2 = false;
                while (!choise2)
                {
                    Console.WriteLine();
                    slee("Välj ett alternativ\n1.Visa alla bord\n2.Lägg till / ändra bordsinformation\n3.Markera att ett bord är tomt\n4.Töm alla bord\n5.Avsluta programmet");
                    choise2 = int.TryParse(Console.ReadLine(), out a);
                }
                if (0 < a && a < 6) choise3 = true;
            }
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
            int guest = 0;
            foreach (string bord in getbordinfo)
            {
                string[] singletableinfo = bord.Split(';');
                guest += int.Parse(singletableinfo[1]);
                Console.Write($"Bord {singletableinfo[0]} - antal gäster: {singletableinfo[1]}");
                if (singletableinfo[2] != baseName)
                {
                    Console.Write($" - Namn: { singletableinfo[2]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Totalt antal gäster: {guest}");
            choise();
        }

        static void bordinfo()
        {

            bool choise3 = false;
            bool choise4 = false;
            int a = 0;
            while (!choise3)
            {
                bool choise2 = false;
                while (!choise2)
                {
                    Console.WriteLine();
                    slee("Vilket bordsnummer vill du lägga till/ändra informationen för? (1-8)");
                    choise2 = int.TryParse(Console.ReadLine(), out a);
                }
                if (0 < a && a < 9) choise3 = true;
            }
            a -= 1;
            slee("Skriv in bordets namn");
            string b = Console.ReadLine();

            int c = 0;
            while (!choise4)
            {
                slee("Hur många gäster finns vid bordet?");
                choise4 = int.TryParse(Console.ReadLine(), out c);
            }
            tempinfo[a] = ($"{a + 1};{c};{b}");
            update();
        }

        static void bordtomt()
        {
            bool choise2 = false;

            int a = 0;
            while (!choise2)
            {
                bool choise1 = false;
                while (!choise1)
                {
                    Console.WriteLine();
                    slee("Vilket bordsnummer vill du markera som tomt?");
                    choise1 = int.TryParse(Console.ReadLine(), out a);
                }
                if (0 < a && a < 9) choise2 = true;
            }
            a -= 1;
            tempinfo[a] = ($"{a + 1};0;Inga gäster");
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
                tempinfo[i] = ($"{i + 1};0;Inga gäster");
            }
            File.WriteAllLines("bord.txt", tempinfo);
            choise();
        }

    }
}