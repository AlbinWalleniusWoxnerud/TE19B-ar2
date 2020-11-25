using System;

namespace Exempel_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 50000;
            int a1 = 30;
            string n1 = "Clara Eklof";
            string n2 = "Anna Johansson";

            Console.WriteLine($"{"Name",-20} {"Inc",15} {"Age",10} \n {n1,-20} {i1,15}{a1,10} \n {n2,-20} {i1,15}{a1,10}");
        }
    }
}
