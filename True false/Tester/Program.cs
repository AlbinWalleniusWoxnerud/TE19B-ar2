using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            new TBA.TextRenderer(new[] {
                new TBA.Text("Hello ").NewLine(false),
                new TBA.Text("Albin ").Speed(500).NewLine(false),
                new TBA.Text("din lilla ").NewLine(false).Pause(400),
                new TBA.Text("BAKA").Speed(400).Pause(300),
                new TBA.Text("Nej skoja bara")
            }).render();

            var result = new TBA.OptionSelector(new TBA.Option[] {
                new TBA.Option("BAKA"),
                new TBA.Option("SUSSY"),
                new TBA.Option("Among us")
            }).get();

            Console.WriteLine(result);
        }
    }
}

