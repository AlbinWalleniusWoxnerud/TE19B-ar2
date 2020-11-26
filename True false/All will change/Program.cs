using System;
using System.IO;
using System.Threading;

namespace All_will_change
{
    class Program
    {
        static
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
            slee("Detta är Centralrestaurangens bordshanterare\nFil med bordsinformation hittades ej, ny information skapades\n");
            choise();
        }
        static void choise()
        {
            slee("Välj ett alternativ\n1.Visa alla bord\n2.Lägg till / ändra bordsinformation\n3.Markera att ett bord är tomt\n4.Avsluta programmet");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    break;
                case 2:
                    bordinfo();
                    break;
                case 3:
                    /* bordtomt(); */
                    break;
                case 4:
                    break;
            }

        }

        static void bordinfo()
        {
            slee("Vilket bordsnummer vill du lägga till/ändra informationen för?");
            int a = int.Parse(Console.ReadLine());
            slee("Skriv in bordets namn");
            string b = Console.ReadLine();
            slee("Hur många gäster finns vid bordet?");
            int c = int.Parse(Console.ReadLine());
            choise();
        }

    }
}