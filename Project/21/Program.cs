using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1;

            Console.WriteLine("Welcome to 21");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Spela 21:an");
            Console.WriteLine("2. Visa senaste vinnaren");
            Console.WriteLine("3. Spelets regler");
            Console.WriteLine("4. Avsluta programmet");
            bool bc1 = int.TryParse(Console.ReadLine(), out c1);
            while(!bc1 || c1 < 1 || c1 > 4) {
                Console.WriteLine("Invalid choise, choose again: ");
                bc1 = int.TryParse(Console.ReadLine(), out c1);
            }

        }
    }
}
