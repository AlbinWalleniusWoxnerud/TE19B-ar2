using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name = "";
            int age = 0;
            int age2025 = 0;
            double height = 0;
            string message = "";

            // Read the name of the user
            Console.Write("What's your name? ");
            name = Console.ReadLine();

            // Read the heigth of the user
            Console.Write("How long are you (in meters)? ");
            height = double.Parse(Console.ReadLine());

            // Read the age of the user
            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());

            // How old the user is in 2025
            age2025 = age + 5;

            // Result
            message = "Hello, " + name + "! " + age + " years old, " + height + " m long." + " You will be " + age2025 + " years old in 2025.";

            Console.WriteLine(message);
        }
    }
}
