using System;
using System.Threading;

namespace Mini_DnD
{
    class Program
    {
        static void Write(string strin)
        {
            for (int i = 0; i <= strin.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2);
                Console.Write(strin.Substring(i, 1));
            }
            if (strin.Length <= 10) Thread.Sleep(500);
            Console.WriteLine();
        }
        static void WriteAscii(string stri)
        {
            for (int i = 0; i <= stri.Length - 1; i++)
            {
                Thread.Sleep(1);
                Console.Write(stri.Substring(i, 1));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string c1;
            string c2;
            string asciibow = @"
                                                       |
                                                        \.
                                                        /|.
                                                      /  `|.
                                                    /     |.
                                                  /       |.
                                                /         `|.
                                              /            |.
                                            /              |.
                                          /                |.
     __                                 /                  `|.
      -\                              /                     |.
        \\                          /                       |.
          \\                      /                         |.
           \|                   /                           |\
             \#####\          /                             ||
         ==###########>     /                               ||
          \##==      \    /                                 ||
     ______ =       =|__/___                                ||
 ,--' ,----`-,__ ___/'  --,-`-==============================##==========>
\               '        ##_______ ______   ______,--,____,=##,__
 `,    __==    ___,-,__,--'#'  ==='      `-'              | ##,-/
   `-,____,---'       \####\              |        ____,--\_##,/
       #_              |##   \  _____,---==,__,---'         ##
        #              ]===--==\                            ||
        #,             ]         \                          ||
         #_            |           \                        ||
          ##_       __/'             \                      ||
           ####='     |                \                    |/
            ###       |                  \                  |.
            ##       _'                    \                |.
           ###=======]                       \              |.
          ///        |                         \           ,|.
          //         |                           \         |.
                                                   \      ,|.
                                                     \    |.
                                                       \  |.
                                                         \|.
                                                         /.
                                                        |
";
            string asciisword = @"
                 /\
                /  |
  *            /  /________________________________________________
 (O)77777777777)  7                                                `~~--__
8OO>>>>>>>>>>>>] <===========================================>          __-
 (O)LLLLLLLLLLL)  L________________________________________________.--~~
  *            \  \
                \  |
                 \/
";
            string asciishield = @"
 _________________________ 
|<><><>     |  |    <><><>|
|<>         |  |        <>|
|           |  |          |
|  (______ <\-/> ______)  |
|  /_.-=-.\| ' |/.-=-._\  |
|   /_    \(o_o)/    _\   |
|    /_  /\/ ^ \/\  _\    |
|      \/ | / \ | \/      |
|_______ /((( )))\ _______|
|      __\ \___/ /__      |
|--- (((---'   '---))) ---|
|           |  |          |
|           |  |          |
:           |  |          :
 \<>        |  |       <>/
  \<>       |  |      <>/
   \<>      |  |     <>/
    `\<>    |  |   <>/'
      `\<>  |  |  <>/'
        `\<>|  |<>/'
          `-.  .-`
            '--'
";
            string died = @"
	
     .... NO! ...                  ... MNO! ...
   ..... MNO!! ...................... MNNOO! ...
 ..... MMNO! ......................... MNNOO!! .
..... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .
 ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....
    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...
   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....
   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...
    ....... MMMMM..    OPPMMP    .,OMI! ....
     ...... MMMM::   o.,OPMP,.o   ::I!! ...
         .... NNM:::.,,OOPM!P,.::::!! ....
          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....
         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....
           .. MMMMMNNOOMMNNIIIPPPOO!! ......
          ...... MMMONNMMNNNIIIOO!..........
       ....... MN MOMMMNNNIIIIIO! OO ..........
    ......... MNO! IiiiiiiiiiiiI OOOO ...........
  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........
   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........
   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........
      ...... OO! ................. ON! .......
         ................................";
            string lived = @"
███████████████████████████████████████
█████████████▓▒░░░░░░░░▒███████████████
███████████▓░░░░░░░░░░░░░▒█████████████
██████████▒░░░▓▓░░░░░░░░░░░▓███████████
█████████░░░░████░░░░░░░░░░░▒██████████
████████░░░░▓█┌┌██░░░░░░░░░░░░█████████
███████░░░░░█▓┌┌┌██░░░░░░░░░░░▒████████
██████░░░░░░▓▓┌┌┌┌█▒░░░░░░░░░░░▓███████
████▓░░░░░░░░█┌┌┌┌┌█░░░░░░░░░░░░░██████
████░░░░░░░░░█▒┌┌┌┌█▓░░░░░░░░░░░░▓█████
███▓░░░░░░░░░█▓┌┌┌┌▓█░░░░░░░░░░░░░█████
███░░░░░░░░░░▓█┌┌┌┌░█░░░░░░░░░░░░░▓████
██▓░░░░░░░░░░▓█┌┌┌┌▒█░░░░░░░░░░░░░░████
██▒░░░░░░░░░░▒█┌┌┌┌▓█░░░░░░░░░░░░░░▓███
██░░░░░░░░░░░▒█┌┌┌┌▓▓░░░░░░░░░░░░░░▒███
█▓░░░░░░░░░░░▓█┌┌┌┌█▓░░▒▒▒░░░░░░░░░░███
█▒░░░░░░░░░░░█▓┌┌┌┌▓█████████▓░░░░░░███
█░░░░░░░░░░░░█░┌┌┌┌┌█▒┌┌┌┌░▒███▓░░░░███
█░░░░░░░░░░░▓█┌┌┌┌┌┌█┌┌┌┌░▓▓┌┌▒██░░░███
█░░░░░░░░░░░█▒┌┌┌┌┌┌█░┌▓██▓▒┌┌┌┌██░░███
█░░░░░░░░░░▓█┌┌┌┌┌┌┌█┌▓█▒┌┌┌┌┌┌┌┌█░░███
█░░░░░░░░░▒█┌┌┌┌┌┌┌░██▓┌┌┌┌┌┌┌┌┌░█░░███
█░░░░░░░░░█▓┌┌┌┌┌┌┌████┌┌┌┌┌┌┌┌▒█▓░░███
█░░░░░░░░░█░┌┌┌┌┌┌┌█░┌██▒┌┌┌▒██▓▒█░░███
█░░░░░░░░▒█┌┌┌┌┌┌┌┌┌┌┌░███████░┌┌█▒░███
█░░░░░░░░▓█┌┌┌┌┌┌┌┌┌┌▒█┌┌┌┌┌┌┌┌┌┌▓▓░███
█░░░░░░░░█▓┌┌┌┌┌┌┌┌┌▓█┌┌┌┌┌┌┌┌┌┌┌█▓░███
█░░░░░████▒┌┌┌┌┌┌┌┌┌░█┌┌┌┌┌┌┌┌┌▒██░░███
█░░░░▓██▓█┌┌┌┌┌┌┌┌┌┌┌██▓░┌░▒▓██▓█▓░░███
█░░░░██┌┌█┌┌┌┌┌┌┌┌┌┌░▓▒██████▓┌┌┌█░░███
█▓░░░█▒┌░█┌┌┌┌┌┌┌┌┌┌▓█┌┌┌┌┌┌┌┌┌┌▒█░░███
██░░░█▒┌┌█┌┌┌┌┌┌┌┌┌▓███┌┌┌┌┌┌┌┌┌█▓░▒███
██▒░░▓▓┌┌█▒┌┌┌┌┌┌┌┌█░┌██▒┌┌┌┌┌░██░░████
███░░▒█┌┌▒█┌┌┌┌┌┌┌┌█┌┌┌▓███▓████▒░░████
███░░░█▓┌┌█▓┌┌┌┌┌┌┌█▒┌┌┌┌▓███▓░█░░▓████
███▓░░▒█┌┌┌█▓┌┌┌┌┌┌▒█┌┌┌┌┌┌┌┌┌▓█░░█████
█████░░░█▓┌┌┌▓██▓┌┌┌┌█▓░┌┌┌▒██▒░░██████
█████▓░░░██┌┌┌█████▒┌┌▓█████▓░░░███████
██████░░░░█████▒░▒████████▓░░░░▓███████
███████░░░░▓██▓░░░░░░▒▒░░░░░░░▒████████
████████░░░░░░░░░░░░░░░░░░░░░▒█████████
██████████▒░░░░░░░░░░░░░░░░▓███████████
████████████▒░░░░░░░░░░░░▒█████████████
";
            double death = 0;
            Console.Clear();
            Write("You awake in a dark room.");
            Write("As you look around you see three pedestals, each with a different item.");
            Write("A bow");
            WriteAscii(asciibow);
            Write("A sword");
            WriteAscii(asciisword);
            Write("And a shield.");
            WriteAscii(asciishield);
            Write("You wonder which one to choose.");
            Write("\nBow");
            Write("Sword");
            Write("Shield");

            Console.Write("\nChoose one: ");
            c1 = Console.ReadLine();
            c1 = c1.ToLower();

            string msg = $"You choose the {c1}.";

            if (c1 == "bow" || c1 == "sword" || c1 == "shield")
            {
                Write(msg);
            }
            else
            {
                death = 1;
                Write("You failed to choose and died as a consequence.");
                WriteAscii(died);
            }
            if (death == 0)
            {
                Write($"As the {c1} enters your hands the pedestals sink into the ground.");
                Write("With a loud rumble the four walls surrounding you collapse reveling four passages.\n");
                Write("North ");
                Write("East");
                Write("South");
                Write("West");

                Console.Write("\nChoose a passage: ");
                c2 = Console.ReadLine();
                c2 = c2.ToLower();

                string msg2 = $"You choose the {c2} passage.";

                if (c2 == "north" || c2 == "east" || c2 == "south" || c2 == "west")
                {
                    if (c2 == "north")
                    {
                        Write(msg2 + " Your choice leds you down a long dark tunnel.");

                        Write("As your walking along you hear a click under your foot.");

                        Write("\nYou Died!");
                        WriteAscii(died);

                    }
                    if (c2 == "east")
                    {
                        Write(msg2 + " Your choice leds you through a tight crevice.");

                        if (c1 == "bow")
                        {
                            Write("As you push yourself through you find traces of footsteps.");

                            Write("You follow the footsteps to a big wooden door with traces of sunlight slipping through.");

                            Write("You Survived");
                            WriteAscii(lived);
                        }
                        else
                        {
                            Write($"As you push deeper into the unknown you find yourself stuck between the wall and the {c1}.");

                            Write("\nYou Died!");
                            WriteAscii(died);

                        }
                    }
                    if (c2 == "south")
                    {
                        Write(msg2 + $"Your choice leds you to a deep dark hole with an unfathomable depth.");

                        Write($"As you stand at the edge of the hole you get the impulse to throw your {c1} down the hole.");

                        Write($"You do it.");

                        Write($"You stare dumbly as the {c1} disappear into the dark.");

                        Write($"As you realise what you've just done you start to loudly curse.");

                        if (c1 == "shield")
                        {
                            Write($"But then you suddenly hear a splash.");

                            Write($"Thinking you have nothing to lose you jump down the hole and plunge into what you assume is water.");

                            Write($"As you surface you see a sliver of sunlight slip through the ivy covering the walls.");

                            Write($"You get out from the water and push through the ivy towards the sunlight.");

                            Write($"\nYou Survived!");
                            WriteAscii(lived);
                        }
                        else
                        {
                            Write($"Having lost your {c1} combined with not knowing whats at the bottom the hole you start walking back.");

                            Write("As your walking you hear a click under your foot.");

                            Write("\nYou Died!");
                            WriteAscii(died);

                        }
                    }
                    if (c2 == "west")
                    {
                        Write(msg2 + " Your choice leds you to a steep staircase.");

                        Write("As you ascend the stairs you come to a plateau with a big rock in the center");

                        Write("As you take a look at the rock you the a small slit as well as an insciption in it.");

                        Write("The inscription reads: Insert the holy sword and peace shall be restored.");

                        if (c1 == "sword")
                        {
                            Write($"Following the inscription you insert the {c1} and immediately feel your eyes blur.");

                            Write("As your vision returns to you you find youself standing in the middle of a town.");

                            Write("\nYou Survived!");
                            WriteAscii(lived);
                        }
                        else
                        {
                            Write($"As you stare dumbly at the insciption you still try to insert your {c1}.");

                            Write("Immediately as you do so you feel your vision darken.");

                            Write("\nYou Died!");
                            WriteAscii(died);

                        }
                    }
                }
                else
                {
                    death = 1;
                    Write("You failed to choose and died as a consequence.");
                    WriteAscii(died);
                }
            }
        }
    }
}
