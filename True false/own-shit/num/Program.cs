using System;

namespace num
{
    class Program
    {
        static bool guessAgainstComputer = false;
        static void Main()
        {
            Console.WriteLine("Guessing game!\n");
            Console.WriteLine("Select a game mode:\n1. Guess against computer.\n2. Choose against computer.\n ");
            choose();
            Console.WriteLine("Enter a range of numbers to guess between.");
            int[] gR = guessRange();
            Console.WriteLine($"You will guess which number the computer chooses between{gR[0]} and {gR[1]}.");
            Console.WriteLine("Make your 1st guess!");

            while (!correktNumber)
            {
                int guess = 0;
                bool validInt = false;
                while (!validInt)
                {
                    validInt = int.TryParse(Console.ReadLine(), out guess);
                }
            }
        }
        static void choose()
        {
            bool correktRange = false;
            int choise = 0;
            while (!correktRange)
            {
                bool correktInt = false;
                while (!correktInt)
                {
                    correktInt = int.TryParse(Console.ReadLine(), out choise);
                    if (!correktInt)
                    {
                        Console.WriteLine("Enter a valid integer!");
                    }
                }
                if (0 < (choise + 1) && (choise + 1) < 3) correktRange = true;
                if (!correktRange) Console.WriteLine("Enter a valid option!");
            }
            if (choise == 0)
            {
                guessAgainstComputer = true;
            }
            return;
        }

        static int[] guessRange()
        {
            int inputRange = 0;
            string tempRange = "";
            string[] firstSecond = { "Lower bound: ", "Upper bound: " };
            foreach (string item in firstSecond)
            {
                bool isInt = false;
                while (!isInt)
                {
                    Console.WriteLine(item);
                    isInt = int.TryParse(Console.ReadLine(), out inputRange);
                }
                tempRange += inputRange;
                tempRange += " ";
            }
            string[] tempRangeArr = tempRange.Trim().Split(" ");
            return (Array.ConvertAll(tempRangeArr, int.Parse));
        }

        static string game()
        {

        }
        static int[] Guesses()
        {
            string tempGuess = "";
            for (int i = 0; i < 2; i++)
            {
                bool validRange = false;
                int guess = 0;
                while (!validRange)
                {

                    bool validInt = false;
                    while (!validInt)
                    {
                        validInt = int.TryParse(Console.ReadLine(), out guess);
                    }
                    if (0 <= gu)
                }
            }
        }
    }
}
