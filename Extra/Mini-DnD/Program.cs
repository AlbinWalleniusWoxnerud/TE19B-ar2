using System;

namespace Mini_DnD
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1;

            Console.Write("You awake in a dark room. As you look around you see three pedistals, each with a different item. A bow, A sword and a Shield. You wonder which one to choose. \nBow \nSword \nShield \nChoose one: ");
            w1 = Console.ReadLine();

            if (w1 == "Bow")
            {
                Console.WriteLine($"You choose the {w1}");
            }

            else if (w1 == "Sword")
            {

                Console.WriteLine($"You choose the {w1}");
            }

            else if (w1 == "Shield")
            {
                Console.WriteLine($"You choose the {w1}");
            }
            else
            {
                Console.WriteLine("You failed to choose and died as a consequence.");
            }
        }
    }
}
