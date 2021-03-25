using System;

namespace prov3
{
    class Program
    {
        /// <summary>
        /// Kod för ålder på vald planet
        /// </summary>
        static void Main()
        ///Main, loopar genom metoder och kallar dem
        {
            Console.WriteLine("Program som räknar ut din ålder på en annan planet.");
            double choise = Age();
            while (true)
            {
                string ageOnChoisePlanet = writeMenu(choise);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(ageOnChoisePlanet);
                Console.ResetColor();
            }
        }
        static double Age()
        ///Return Age
        {
            ///Kollar att åldern är ett nummer samt att det är innanför spanet av 1-129 år
            ///Om man väljer något annat än 1-129 får man göra om
            Console.WriteLine("Ange din ålder i jordår: ");
            int temp = 0;
            bool correkt = false;
            while (!correkt)
            {
                bool trueCorrekt = false;
                while (!trueCorrekt)
                {
                    trueCorrekt = int.TryParse(Console.ReadLine(), out temp);
                    if (!trueCorrekt)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input, try again!");
                        Console.ResetColor();
                        Console.WriteLine("Ange din ålder i jordår: ");
                    }
                }
                if (0 < temp && temp < 130) correkt = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, try again!");
                    Console.ResetColor();
                    Console.WriteLine("Ange din ålder i jordår: ");
                }
            }
            return temp;
        }
        static string writeMenu(double age)
        ///Skriv ut alla alternativ samt return string hur gammal man är på vald planet
        {
            string alternativ = ("\nVälj ett alternativ\n1.Räkna ut ålder på Merkurius\n2.Räkna ut ålder på Venus\n3.Räkna ut ålder på Mars\n4.Räkna ut ålder på Jupiter\n5.Räkna ut ålder på Saturnus\n6.Räkna ut ålder på Uranus\n7.Räkna ut ålder på Neptunus\n8.Avsluta");
            Console.WriteLine(alternativ);
            int temp = 0;

            ///Kollar att du har vald ett av de alternativ som finns att välja mellan, dvs 1-8
            ///Om man väljer något annat än 1-8 får man göra om
            bool correkt = false;
            while (!correkt)
            {
                bool trueCorrekt = false;
                while (!trueCorrekt)
                {
                    trueCorrekt = int.TryParse(Console.ReadLine(), out temp);
                    if (!trueCorrekt)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wrong input, try again!");
                        Console.ResetColor();
                        Console.WriteLine(alternativ);
                    }
                }
                if (0 < temp && temp < 9) correkt = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong input, try again!");
                    Console.ResetColor();
                    Console.WriteLine(alternativ);
                }
            }
            ///Beronde på vald plnaet return olika åldrar
            switch (temp)
            {
                case 1:
                    return ($"På Merkurius är du {age / 0.2408467} år gammal.");
                case 2:
                    return ($"På Venus är du {age / 0.61519726} år gammal.");
                case 3:
                    return ($"På Mars är du {age / 1.8808158} år gammal.");
                case 4:
                    return ($"På Jupiter är du {age / 11.862615} år gammal.");
                case 5:
                    return ($"På Saturnus är du {age / 29.447498} år gammal.");
                case 6:
                    return ($"På Uranus är du {age / 84.016846} år gammal.");
                case 7:
                    return ($"På Neptunus är du {age / 164.79132} år gammal.");
                case 8:
                    Console.WriteLine($"Avslutar");
                    System.Environment.Exit(0);
                    return "Exit";
            }
            ///Blir arg annars, all paths do not return a value.
            return "Exit";
        }

    }
}
