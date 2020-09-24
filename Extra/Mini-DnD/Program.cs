using System;

namespace Mini_DnD
{
    class Program
    {
        static void Main(string[] args)
        {
            string c1;
            string c2;
            double death = 0;

            Console.Write("You awake in a dark room. As you look around you see three pedistals, each with a different item. A bow, A sword and a Shield. You wonder which one to choose. \nBow \nSword \nShield \nChoose one: ");
            c1 = Console.ReadLine();

            string msg = $"You choose the {c1}";

            if (c1 == "Bow" || c1 == "Sword" || c1 == "Shield")
            {
                Console.WriteLine(msg);
            }
            else
            {
                death = 1;
                Console.WriteLine("You failed to choose and died as a consequence.");
            }
            if (death == 0)
            {
                Console.Write($"As the {c1} enters your hands the pedistals sink into the ground. With a loud rumble the four walls surrounding you collapse reveling four passages. \nNorth \nEast \nSouth \nWest \nChoose a passage: ");
                c2 = Console.ReadLine();
                if (c2 == "North" || c2 == "East" || c2 == "South" || c2 == "West")
                {
                    Console.WriteLine(c2);
                }
            }
        }
    }
}
