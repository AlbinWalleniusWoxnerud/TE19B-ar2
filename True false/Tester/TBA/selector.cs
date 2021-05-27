using System;
using System.Threading;

namespace TBA
{
    class OptionSelector {
        int cursorPos = 0;
        Option[] _options;

        public OptionSelector(Option[] _Options) {
            _options = _Options;
        }

        private void moveCursorPos(int amount, int min, int max) {
            cursorPos = cursorPos + amount;
            if(cursorPos >= max) {
                cursorPos = max - 1;
            }
            if(cursorPos < min) {
                cursorPos = min;
            }
        }

        void drawAtPos(string text, int pos) {
            Console.SetCursorPosition(0, pos);
            Console.Write(text);
        }

        public int get() {
            int intialTop = Console.CursorTop;

            string printString = "\n";
            foreach(Option option in _options) {
                printString += "  " + option.title + "\n";
            }
            Console.WriteLine(printString);
            drawAtPos(">", intialTop + cursorPos + 1);
            while (true) {
                switch(Console.ReadKey(true).Key) {
                    case ConsoleKey.DownArrow:
                        drawAtPos(" ", intialTop + cursorPos + 1);
                        moveCursorPos(1,0,_options.Length);
                        drawAtPos(">", intialTop + cursorPos + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        drawAtPos(" ", intialTop + cursorPos + 1);
                        moveCursorPos(-1,0,_options.Length);
                        drawAtPos(">", intialTop + cursorPos + 1);
                        break;
                    case ConsoleKey.Enter:
                        int newCursor = intialTop;
                        for(int i = 0; i <= _options.Length; i++) {
                            newCursor++;
                            Console.SetCursorPosition(0, newCursor);
                            Console.Write(new string(' ', Console.WindowWidth)); 
                        }
                        Console.SetCursorPosition(0, intialTop);
                        return cursorPos;
                }
            }
        }
    }


    
    public class Option
    {

        private string _title;
        public string title {
            get {
                return _title;
            }

            set {
                _title = value;
            }
        }

        public Option(string _Title)
        {
            _title = _Title;
        }

    }

}