using System;

namespace Extract_url
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput;
            string msg;
            int l1;
            int l2;
            int l3;
            int l4;
            string w1;
            string w2;
            string w3;
            string w4;
            string w5;

            Console.Write("Enter a URL: ");
            imput = Console.ReadLine();

            l1 = imput.IndexOf("://");
            w1 = imput.Substring(0, l1);
            l1 = l1 + 3;
            l2 = imput.IndexOf(".");
            w2 = imput.Substring(l1, l2 - l1);
            l2 = l2 + 1;
            l3 = imput.IndexOf(".", l2);
            w3 = imput.Substring(l2, l3 - l2);
            l3 = l3 + 1;
            l4 = imput.IndexOf("/", l1);
            w4 = imput.Substring(l3, l4 - l3);
            l4 = l4 + 1;
            w5 = imput.Substring(l4);


            msg = $"Protocol: {w1}\nSubdomain: {w2}\nDomain: {w3}\nTop Level Domain: {w4}\nPath: {w5}";


            Console.WriteLine(msg);
        }
    }
}
