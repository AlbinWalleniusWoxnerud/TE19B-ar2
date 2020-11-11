using System;

namespace Exempel_3._7
{
    class Program
    {
        static void Main()
        {
            double marginalskatt;
            double nettolön;
            int lön;
            string svar;
            while (true)
            {
                Console.WriteLine("Skriv in din lön! (Endast siffor)");
                bool success = int.TryParse(Console.ReadLine(), out lön);
                {
                    if (success == false)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Endast siffor, pröva igen");
                        Console.ResetColor();
                    }
                    if (lön > 0)
                    {
                        if (lön < 10000)
                        {
                            marginalskatt = lön * 0.08;
                            nettolön = lön - marginalskatt;
                            Console.WriteLine($"Om du tjänar {lön} kr är din nettolön: {nettolön}, din marginalskatt är {marginalskatt} eller 8%");
                            Console.WriteLine("Vill du göra en ny beräkning? J/N");
                            svar = Console.ReadLine();
                            svar = svar.ToLower();
                            if (svar != "j")
                            {
                                break;
                            }
                        }
                        else if (lön >= 10000 && lön < 145000)
                        {
                            marginalskatt = lön * 0.22;
                            nettolön = lön - marginalskatt;
                            Console.WriteLine($"Om du tjänar {lön} kr är din nettolön: {nettolön}, din marginalskatt är {marginalskatt} eller 22%");
                            Console.WriteLine("Vill du göra en ny beräkning? J/N");
                            svar = Console.ReadLine();
                            svar = svar.ToLower();
                            if (svar != "j")
                            {
                                break;
                            }
                        }
                        else if (lön >= 145000 && lön < 515000)
                        {
                            marginalskatt = lön * 0.33;
                            nettolön = lön - marginalskatt;
                            Console.WriteLine($"Om du tjänar {lön} kr är din nettolön: {nettolön}, din marginalskatt är {marginalskatt}  eller 33%");
                            Console.WriteLine("Vill du göra en ny beräkning? J/N");
                            svar = Console.ReadLine();
                            svar = svar.ToLower();
                            if (svar != "j")
                            {
                                break;
                            }
                        }
                        else if (lön >= 515000)
                        {
                            marginalskatt = lön * 0.53;
                            nettolön = lön - marginalskatt;
                            Console.WriteLine($"Om du tjänar {lön} kr är din nettolön: {nettolön}, din marginalskatt är {marginalskatt} eller 53%");
                            Console.WriteLine("Vill du göra en ny beräkning? J/N");
                            svar = Console.ReadLine();
                            svar = svar.ToLower();
                            if (svar != "j")
                            {
                                break;
                            }
                        }
                    }

                }
            }
        }
    }
}