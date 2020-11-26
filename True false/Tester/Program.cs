using System;
using System.IO;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta program skriver och läser information från filer");
            Console.WriteLine();
            string[] temp = namn;
            string[] namn = new string[9];
            for (int i = 0; i < 10; i++)
            {
                namn[i] = "Hello";
            }

            // Skapa eller skriv över fil1.txt
            File.WriteAllText("fil1.txt", "Detta skrivs i fil 1");

            // Skapa eller skriv över fil2.txt
            File.WriteAllLines("fil2.txt", namn);

            // Läs in och skriv ut innehållet i fil1.txt
            Console.WriteLine("Här är innehållet i fil1.txt");
            string fil1Innehåll = File.ReadAllText("fil1.txt");
            Console.WriteLine(fil1Innehåll);
            Console.WriteLine();

            // Läs in innehållet i fil2.txt.
            string[] fil2Innehåll = File.ReadAllLines("fil2.txt");

            // Skriv ut varje rad från fil2.txt på var sin rad
            Console.WriteLine("Här är innehållet i fil2.txt");
            foreach (string rad in fil2Innehåll)
            {
                Console.WriteLine(rad);
            }
            Console.WriteLine();

            // Kolla om det finns en fil som heter fil1.txt
            if (File.Exists("fil1.txt"))
            {
                Console.WriteLine("Det finns en fil som heter fil1.txt");
            }
            else
            {
                Console.WriteLine("Det finns INTE en fil som heter fil1.txt");
            }

            // Avsluta inte direkt
            Console.ReadKey();
        }
    }
}
