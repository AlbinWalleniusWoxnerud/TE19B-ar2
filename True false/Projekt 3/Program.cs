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
        static int shot_x;
        static int shot_y;
        static string[,] player = new string[boardheight, boardwidth];
        static string[,] computer = new string[boardheight, boardwidth];
        static string[,] computerfalse = new string[boardheight, boardwidth];

        static void slee(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                string b = a.Substring(i, 1);
                Console.Write(a[i]);
                Thread.Sleep(1);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            slee("\nWelcome to summoners rift!");
            choise();
        }
        static void choise()
        {
            slee("Choose an alternative\n1.Play\n2.Last Winner\n3.Scoreboard\n4.Exit");
            int choise_input = int.Parse(Console.ReadLine());
            switch (choise_input)
            {
                case 1:
                    reset();
                    break;
                case 2:
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
            slee("Settings boards");
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    player[i, j] = "0";
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

            boat();
        }

        static void play()
        {
            bool gameover = false;

            slee("Game start\nYour turn!\n\nYour board");
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    Console.Write(player[i, j]);
                }
                Console.WriteLine();
            }
            slee("\n\nComputer board");
            int limit = 1;
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    if (computerfalse[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ResetColor();
                    }
                    else if (computer[i, j] == computer[shot_y, shot_x] && computer[shot_y, shot_x] == "X" && limit == 1)
                    {
                        limit = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ResetColor();
                    }
                    else Console.Write(computerfalse[i, j]);
                }
                Console.WriteLine();
            }
            slee("\n\nComputer true board");
            for (int i = 0; i < boardheight; i++)
            {
                for (int j = 0; j < boardwidth; j++)
                {
                    Console.Write(computer[i, j]);
                }
                Console.WriteLine();
            }
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
                if (player[player_boat_pos_x, player_boat_pos_y] == "X" || computer[computer_boat_pos_x, computer_boat_pos_y] == "X")
                {
                    if (i == 0) i = 0;
                    else i--;
                    continue;
                }
                player[player_boat_pos_x, player_boat_pos_y] = "X";
                computer[computer_boat_pos_x, computer_boat_pos_y] = "X";
            }
            play();
        }

        static void shot()
        {
            slee("\nWhere do you want to shoot? (Y)");
            shot_y = int.Parse(Console.ReadLine());
            shot_y--;
            slee("Where do you want to shoot? (X)");
            shot_x = int.Parse(Console.ReadLine());
            shot_x--;
            if (computer[shot_y, shot_x] == "X")
            {
                computerfalse[shot_y, shot_x] = "X";
            }
            play();
        }

    }
}
