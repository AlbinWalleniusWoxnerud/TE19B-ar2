using System;
using System.Threading;

namespace Mini_DnD
{
    class Program
    {
        static void Main(string[] args)
        {
            string c1;
            string c2;
            double death = 0;

            Console.WriteLine("You awake in a dark room.");
            Thread.Sleep(2000);
            Console.WriteLine("As you look around you see three pedestals, each with a different item.");
            Thread.Sleep(2000);
            Console.WriteLine("A bow, A sword and a Shield.");
            Thread.Sleep(2000);
            Console.WriteLine("You wonder which one to choose.");
            Thread.Sleep(2000);
            Console.WriteLine("Bow");
            Thread.Sleep(2000);
            Console.WriteLine("Sword");
            Thread.Sleep(2000);
            Console.WriteLine("Shield");
            Thread.Sleep(2000);
            Console.Write("\nChoose one: ");
            c1 = Console.ReadLine();

            string msg = $"You choose the {c1}.";
            Thread.Sleep(2000);

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
                Console.WriteLine($"As the {c1} enters your hands the pedestals sink into the ground.");
                Thread.Sleep(2000);
                Console.WriteLine("With a loud rumble the four walls surrounding you collapse reveling four passages.\n");
                Thread.Sleep(2000);
                Console.WriteLine("North ");
                Thread.Sleep(2000);
                Console.WriteLine("East");
                Thread.Sleep(2000);
                Console.WriteLine("South");
                Thread.Sleep(2000);
                Console.WriteLine("West");
                Thread.Sleep(2000);
                Console.Write("\nChoose a passage: ");
                c2 = Console.ReadLine();
                string msg2 = $"You choose the {c2} passage.";
                Thread.Sleep(2000);
                if (c2 == "North" || c2 == "East" || c2 == "South" || c2 == "West")
                {
                    if (c2 == "North")
                    {
                        Console.WriteLine(msg2 + " Your choice leds you down a long dark tunnel.");
                        Thread.Sleep(2000);
                        Console.WriteLine("As your walking along you hear a click under your foot.");
                        Thread.Sleep(5000);
                        Console.WriteLine("\nYou Died!");
                    }
                    if (c2 == "East")
                    {
                        Console.WriteLine(msg2 + " Your choice leds you through a tight crevice.");
                        Thread.Sleep(2000);
                        if (c1 == "Bow")
                        {
                            Console.WriteLine("As you push yourself through you find traces of footsteps.");
                            Thread.Sleep(2000);
                            Console.WriteLine("You follow the footsteps to a big wooden door with traces of sunlight slipping through.");
                            Thread.Sleep(5000);
                            Console.WriteLine("You Survived");
                        }
                        else
                        {
                            Console.WriteLine($"As you push deeper into the unknown you find yourself stuck between the wall and the {c1}.");
                            Thread.Sleep(5000);
                            Console.WriteLine("\nYou Died!");
                        }
                    }
                    if (c2 == "South")
                    {
                        Console.WriteLine(msg2 + $"Your choice leds you to a deep dark hole with an unfathomable depth.");
                        Thread.Sleep(2000);
                        Console.WriteLine($"As you stand at the edge of the hole you get the impulse to throw your {c1} down the hole.");
                        Thread.Sleep(2000);
                        Console.WriteLine($"You do it.");
                        Thread.Sleep(2000);
                        Console.WriteLine($"You stare dumbly as the {c1} disappear into the dark.");
                        Thread.Sleep(2000);
                        Console.WriteLine($"As you realise what you've just done you start to loudly curse.");
                        Thread.Sleep(2000);
                        if (c1 == "Shield")
                        {
                            Console.WriteLine($"But then you suddenly hear a splash.");
                            Thread.Sleep(2000);
                            Console.WriteLine($"Thinking you have nothing to lose you jump down the hole and plunge into what you assume is water.");
                            Thread.Sleep(2000);
                            Console.WriteLine($"As you surface you see a sliver of sunlight slip through the ivy covering the walls.");
                            Thread.Sleep(2000);
                            Console.WriteLine($"You get out from the water and push through the ivy towards the sunlight.");
                            Thread.Sleep(5000);
                            Console.WriteLine($"\nYou Survived!");
                        }
                        else
                        {
                            Console.WriteLine($"Having lost your {c1} combined with not knowing whats at the bottom the hole you start walking back.");
                            Thread.Sleep(2000);
                            Console.WriteLine("As your walking you hear a click under your foot.");
                            Thread.Sleep(5000);
                            Console.WriteLine("\nYou Died!");
                        }
                    }
                    if (c2 == "West")
                    {
                        Console.WriteLine(msg2 + " Your choice leds you to a steep staircase.");
                        Thread.Sleep(2000);
                        Console.WriteLine("As you ascend the stairs you come to a plateau with a big rock in the center");
                        Thread.Sleep(2000);
                        Console.WriteLine("As you take a look at the rock you the a small slit as well as an insciption in it.");
                        Thread.Sleep(2000);
                        Console.WriteLine("The inscription reads: Insert the holy Sword and peace shall be restored.");
                        Thread.Sleep(2000);
                        if (c1 == "Sword")
                        {
                            Console.WriteLine($"Following the inscription you insert the {c1} and immediately feel your eyes blur.");
                            Thread.Sleep(2000);
                            Console.WriteLine("As your vision returns to you you find youself standing in the middle of a town.");
                            Thread.Sleep(5000);
                            Console.WriteLine("\nYou Survived!");
                        }
                        else
                        {
                            Console.WriteLine($"As you stare dumbly at the insciption you still try to insert your {c1}.");
                            Thread.Sleep(2000);
                            Console.WriteLine("Immediately as you do so you feel your vision darken.");
                            Thread.Sleep(5000);
                            Console.WriteLine("\nYou Died!");
                        }
                    }
                }
            }
        }
    }
}
