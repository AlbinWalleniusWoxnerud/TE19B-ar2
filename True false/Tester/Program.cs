using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Tester
{
    class Program
    {
        static int boardheight = 10;
        static int boardwidth = 10;
        static string[,] player = new string[boardheight, boardwidth];

        static void Main(string[] args)
        {
            // Declare the array of four elements:  
            /*  string[][] jaggedArray = new string[4][];
             // Initialize the elements:  
             jaggedArray[0] = new string[6] { "0", "0", "0", "0", "0", "0" };
             jaggedArray[1] = new string[6] { "0", "0", "0", "0", "0", "0" };
             jaggedArray[2] = new string[6] { "0", "0", "0", "0", "0", "0" };
             jaggedArray[3] = new string[6] { "0", "0", "0", "0", "0", "0" };

             // Display the array elements:  
             for (int i = 0; i < jaggedArray.Length; i++)
             {
                 System.Console.Write("Element({0}): ", i + 1);
                 for (int j = 0; j < jaggedArray[i].Length; j++)
                 {
                     System.Console.Write(jaggedArray[i][j] + " ");
                 }
                 System.Console.WriteLine();
             }
             for (int i = 0; i < jaggedArray.Length; i++)
             {
                 for (int j = 0; j < jaggedArray[i].Length; j++)
                 {
                     string[] etstst = jaggedArray[i];
                     File.WriteAllLines("test.txt", etstst);
                 }
             } */

            for (int k = 0; k < 1; k++)
            {
                for (int i = 0; i < boardheight; i++)
                {
                    for (int j = 0; j < boardwidth; j++)
                    {
                        player[i, j] = "O ";
                    }
                }
                Random ran = new Random();
                for (int i = 0; i < 1; i++)
                {
                    /* int player_boat_pos_x = ran.Next(0, 10);
                    int player_boat_pos_y = ran.Next(0, 10); */
                    int player_boat_pos_x = 0;
                    int player_boat_pos_y = 9;
                    if (player[player_boat_pos_x, player_boat_pos_y] == "X ")
                    {
                        if (i == 0)
                        {
                            i = 0;
                        }
                        else
                        {
                            i--;
                        }
                        continue;
                    }
                    player[player_boat_pos_x, player_boat_pos_y] = "X ";
                }
                for (int i = 0; i < boardheight; i++)
                {
                    for (int j = 0; j < boardwidth; j++)
                    {
                        Console.Write(player[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

