using System;

namespace _21
{
    class Program
    {
        static void Main()
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
            switch (c1) {
                case 1:
                play();
                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                break;
            }


        } 

        static void play() {
            Random rnd = new Random();
            bool p = true;
            bool first = true;
            int total = 0;
            int total1 = 0;
            int draw = 0;
            int draw1 = 0;
            int fdraw = 0;
            int fdraw1 = 0;

            while (p) {
                if (first) {
                    fdraw = rnd.Next(1,11);
                    total = fdraw;
                    fdraw1 = rnd.Next(1,11);
                    total1 = fdraw1;
                    draw1 = rnd.Next(1,11);
                    total1 = total1 + draw1;
                }
                    draw = rnd.Next(1,11);
                    total = total + draw;
                if (first) {
                    Console.WriteLine($"Du drog {fdraw} och {draw} för en total: {total}");
                    Console.WriteLine($"Dator: {total1}");
                    first = false;
                }
                else
                {
                    Console.WriteLine($"Du drog {draw} för en total: {total}");   
                    Console.WriteLine($"Dator: {total1}");
                }
                if (total > 21) {
                    Console.WriteLine("Datorn vann");
                    break;
                }
                Console.WriteLine("Vill du ha ett till kort? (J/N)");
                string svar = Console.ReadLine();
                if (svar.ToLower() == "j") {
                    continue;
                }
                else {
                    while (total1 <= total && total <= 21) 
                    {
                        draw1 = rnd.Next(1,11);
                        total1 = total1 + draw1;
                        Console.WriteLine($"Dator drog.");
                        Console.WriteLine($"Dator: {total1}");
                    }
                }
                if (total1 >= total && total1 <= 21 || total > 21) {
                    Console.WriteLine("Datorn vann");
                    break;
                }
                if (total > total1 && total <= 21) {
                     Console.WriteLine("Du vann");
                     break;
                }
            }
            Main();
        }
    }
}