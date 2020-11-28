using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Projekt_3
{
    class Program
    {
        static int boardheight = 4;
        static int boardwidth = 6;
        static int boats = 2;
        static int player_hit = 0;
        static int computer_hit = 0;
        static int shot_x;
        static int shot_y;
        static int computer_shot_x;
        static int computer_shot_y;
        static string[,] player = new string[boardheight, boardwidth];
        static string[,] computer = new string[boardheight, boardwidth];
        static string[,] computerfalse = new string[boardheight, boardwidth];

        static void slee(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                string b = a.Substring(i, 1);
                Console.Write(a[i]);
                Thread.Sleep(25);
            }
            Console.WriteLine();
        }
        static void slow_slee(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                string b = a.Substring(i, 1);
                Console.Write(a[i]);
                Thread.Sleep(100);
            }
        }
        static void Main()
        {
            slee("\nWelcome to summoners rift!");
            choise();
        }
        static void choise()
        {
            slee("Choose an alternative\n1.Play\n2.Game rules\n3.Last Winner\n4.Scoreboard\n5.Exit");
            int choise_input = int.Parse(Console.ReadLine());
            switch (choise_input)
            {
                case 1:
                    reset();
                    break;
                case 2:
                    rules();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
            }
        }
        static void reset()
        {
            slee("\nSettings boards");
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    player[i, j] = "-";
                }
            }

            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    computer[i, j] = "-";
                }
            }

            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    computerfalse[i, j] = "-";
                }
            }

            player_hit = 0;
            computer_hit = 0;
            slee("\nPress any key so start!");
            Console.ReadKey();
            slee("Game starting!");
            boat();
        }

        static void draw()
        {
            slee("\nYour board:");
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    slow_slee(player[i, j]);
                }
                Console.WriteLine();
            }

            slee("\n\nComputer board:");
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    slow_slee(computerfalse[i, j]);
                }
                Console.WriteLine();
            }

            /* slee("\n\nComputer true board");
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    slow_slee(computer[i, j]);
                }
                Console.WriteLine();
            } */
            shot();
        }

        static void boat()
        {
            Random ran = new Random();
            for (int i = 0; i < boats; i++)
            {
                int player_boat_pos_x = ran.Next(0, boardheight);
                int player_boat_pos_y = ran.Next(0, boardwidth);
                int computer_boat_pos_x = ran.Next(0, boardheight);
                int computer_boat_pos_y = ran.Next(0, boardwidth);
                if (player[player_boat_pos_x, player_boat_pos_y] == "O" || computer[computer_boat_pos_x, computer_boat_pos_y] == "X")
                {
                    if (i == 0) i = 0;
                    else i--;
                    continue;
                }
                player[player_boat_pos_x, player_boat_pos_y] = "O";
                computer[computer_boat_pos_x, computer_boat_pos_y] = "X";
            }
            draw();
        }

        static void shot()
        {
            slee("\nWhere do you want to shoot? (Y, 1-4)");
            shot_y = int.Parse(Console.ReadLine());
            shot_y--;
            slee("Where do you want to shoot? (X, 1-6)");
            shot_x = int.Parse(Console.ReadLine());
            shot_x--;

            if (computer[shot_y, shot_x] == "X")
            {
                player_hit++;
                computerfalse[shot_y, shot_x] = "X";
            }
            else computerfalse[shot_y, shot_x] = "0";
            computer_shot();
        }
        static void computer_shot()
        {
            for (int i = 0; i < 1; i++)
            {
                Random ran = new Random();
                int computer_shot_y = ran.Next(0, boardheight);
                int computer_shot_x = ran.Next(0, boardwidth);

                if (player[computer_shot_y, computer_shot_x] == "O")
                {
                    computer_hit++;
                    player[computer_shot_y, computer_shot_x] = "X";
                }
                else if (player[computer_shot_y, computer_shot_x] == "M")
                {
                    i--;
                    continue;
                }
                else
                {
                    player[computer_shot_y, computer_shot_x] = "M";
                }
            }
            check();
        }

        static void check()
        {
            if (player_hit == boats && computer_hit == boats)
            {
                slee("\n\nDraw, No Winner!");
                choise();
            }
            else if (player_hit == boats)
            {
                slee("\n\nYou win!");
                choise();
            }
            else if (computer_hit == boats)
            {
                slee("\n\nComputers wins, you lose!");
                choise();
            }
            else
            {
                draw();
            }
        }
        static void rules()
        {
            slee($"\nGame rules:\nBoardheight: {boardheight}\nBoardwidth: {boardwidth}\nBoats: {boats}");
            slee("\nChoose an alternative\n1.Change the rules\n2.Reset the rules\n3.Return to menu");
            int rules_ans = int.Parse(Console.ReadLine());
            switch (rules_ans)
            {
                case 1:
                    change_rules();
                    break;

                case 2:
                    reset_rules();
                    break;

                case 3:
                    choise();
                    break;
            }
        }

        static void change_rules()
        {
            slee("Are you sure would like to change the rules? Y/N ");
            string rules_ans = Console.ReadLine().ToLower();
            if (rules_ans == "y")
            {
                slee("Change boardheight to: ");
                boardheight = int.Parse(Console.ReadLine());
                slee("Change boardwidth to: ");
                boardwidth = int.Parse(Console.ReadLine());
                slee("Change boat amount to: ");
                boats = int.Parse(Console.ReadLine());
                slee("\nRules changed!");
                choise();
            }
            else
            {
                choise();
            }
        }

        static void reset_rules()
        {
            slee("Resetting game rules...");
            boardheight = 4;
            boardwidth = 6;
            boats = 2;
            Thread.Sleep(200);
            slee("\nRules reset!");
            choise();
        }

    }
}
