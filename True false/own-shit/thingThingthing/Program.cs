using System;

namespace thingThingthing
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1;             // Copies p1 reference

            Console.WriteLine(p1.X);  // 7
            Console.WriteLine(p2.X);  // 7

            p1.X = 9;                  // Change p1.X

            Console.WriteLine(p1.X);  // 9
            Console.WriteLine(p2.X);  // 9
        }
    }
    public class UnitConverter
    {
        int ratio;
        public UnitConverter(int unitRatio)
        {
            ratio = unitRatio;
        }
        public int Convert(int unit)
        {
            return unit * ratio;
        }
    }
    public struct Point { public int X, Y; }
}
