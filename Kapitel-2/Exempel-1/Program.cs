using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabel för namnet
            string namn = "Albin";
            string hobby1 = "game";

            // Specificerat meddelande
            //string mede = "HejHejLeverPastej";

            // Läs in namn från console
            Console.Write("What u heter? ");
            namn = Console.ReadLine();

            // Läs in hobby från console
            Console.Write("What hobby u have? ");
            hobby1 = Console.ReadLine();

            // Skriv ut namn och hobby
            Console.WriteLine("Hello " + namn + "! Hobby: " + hobby1 + ".");

            // Skriv ut specificerat meddelande
            //Console.WriteLine(mede);
        }
    }
}
