using System;
using System.Threading;

namespace _21
{
    class Program
    {
        static public string Winner = "";

        static void Write(string strin)
        {
            for (int i = 0; i <= strin.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(20);
                Console.Write(strin.Substring(i, 1));
            }
            if (strin.Length <= 10) Thread.Sleep(500);
            Console.WriteLine("");
        }

        static void Main()
        {
            int c1;

            Write("Welcome to 21");
            Write("Choose an option: ");
            Write("1. Spela 21:an");
            Write("2. Visa senaste vinnaren");
            Write("3. Spelets regler");
            Write("4. Avsluta programmet");
            Write("");
            bool bc1 = int.TryParse(Console.ReadLine(), out c1);
            while(!bc1 || c1 < 1 || c1 > 4) {
                Write("Invalid choise, choose again: ");
                bc1 = int.TryParse(Console.ReadLine(), out c1);
            }
            switch (c1) {
                case 1:
                play();
                break;

                case 2:
                Write($"Senaste vinnaren: {Winner}");
                Write("");
                Main();
                break;

                case 3:
                Write("4789350923465934865+12968");
                Write("");
                Main();
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
                    total = total + fdraw;
                    fdraw1 = rnd.Next(1,11);
                    total1 = fdraw1;
                    draw1 = rnd.Next(1,11);
                    total1 = total1 + draw1;
                }
                    draw = rnd.Next(1,11);
                    total = total + draw;

                if (first) 
                {
                    Write($"Du drog {fdraw} och {draw} för en total: {total}");
                    Write($"Dator: {total1}");
                    Write("");
                    first = false;
                }
                else
                {
                    Write("");
                    Write($"Du drog {draw} för en total: {total}");   
                    Write($"Dator: {total1}");
                    Write("");
                }

                if (total > 21) 
                {
                    Write("Datorn vann");
                    Write($"Spelare: {total}");
                    Write($"Dator: {total1}");
                    Winner = "Datorn";
                    Write("");
                    break;
                }
                Console.Write("Vill du ha ett till kort? (J/N) ");
                string svar = Console.ReadLine();
                if (svar.ToLower() == "j") {
                    continue;
                }
                else 
                {
                    if (total1 >= total && total1 <= 21 || total > 21) 
                    {
                        Write("Datorn vann");
                        Write($"Spelare: {total}");
                        Write($"Dator: {total1}");
                        Write("");
                        Winner = "Datorn";
                        break;
                    }

                    while (total1 <= total && total <= 21 || total1 < 21) 
                    {
                        draw1 = rnd.Next(1,11);
                        total1 = total1 + draw1;
                        Write("");
                        Write($"Dator drog: {draw1}.");
                        Write($"Dator: {total1}");
                        Write("");
                    }
                    if (total1 > 21) 
                    {
                        Write("Du vann");
                        Write($"Spelare: {total}");
                        Write($"Dator: {total1}");
                        Write("");
                        win();
                        break;
                    }
                }

                if (total1 >= total && total1 <= 21 || total > 21) {
                    Write("Datorn vann");
                    Write($"Spelare: {total}");
                    Write($"Dator: {total1}");
                    Write("");
                    Winner = "Datorn";
                    break;
                }
                if (total > total1 && total <= 21) {
                    Write("Du vann");
                    Write($"Spelare: {total}");
                    Write($"Dator: {total1}");
                    Write("");
                    win();
                    break;
                }
            }
            Main();
        }

        static void win() 
        {
            Console.Write("Skriv ditt namn: ");
            Winner = System.Console.ReadLine();
        }
    }
}