using System;

namespace Exempel_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int jump = 0;
            int wrjump = 245;
            int jumpdiff = 0;
            string message = "";

            // Ask the user
            Console.Write("How high can you jump(in cm)? ");
            jump = int.Parse(Console.ReadLine());

            // Difference between the wrjump and the users jump
            jumpdiff = wrjump - jump;

            // Result, this is done in cm not meters
            message = "Your jump of " + jump + " cm is quite good, but compared to the world record jump of " + wrjump + " cm it's not that much. The difference between them is " + jumpdiff + " cm.";

            Console.WriteLine(message);
        }
    }
}
