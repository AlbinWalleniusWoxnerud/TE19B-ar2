using System;

namespace Exempel_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double jump = 0;
            double wrjump = 2.45;
            double jumpdiff = 0;
            string message = "";

            // Ask the user
            Console.Write("How high can you jump(in meters)? ");
            jump = double.Parse(Console.ReadLine());

            // Difference between the wrjump and the users jump
            jumpdiff = wrjump - jump;

            // Result, this is done in cm not meters
            message = "Your jump of " + jump + " m is quite good, but compared to the world record jump of " + wrjump + " cm its not that much. The difference between them is " + jumpdiff + " m.";

            Console.WriteLine(message);
        }
    }
}
