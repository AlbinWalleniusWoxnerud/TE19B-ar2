using System;
using System.Threading;

namespace TBA
{

    public class TextRenderer
    {
        private Text[] texts;

        public TextRenderer(Text[] _texts)
        {
            texts = _texts;
        }

        public void render()
        {

            foreach (Text text in texts)
            {

                foreach (char letter in text.title)
                {
                    Console.Write(letter);
                    Thread.Sleep(text.speed);
                }

                if (text.newLine)
                {
                    Console.Write("\n");

                }
                Thread.Sleep(text.pause);
            }

        }
    }

    public class Text
    {

        public string _title;
        public int _speed;
        public bool _newLine;
        public int _pause;

        public int pause {
            get{
                return _pause;
            }
            set {
                Pause(value);
            }
        }

        public int speed {
            get{
                return _speed;
            }
            set {
                Speed(value);
            }
        }

        public bool newLine {
            get{
                return _newLine;
            }
            set {
                NewLine(value);
            }
        }

        public string title {
            get {
                return _title;
            }
        }

        public Text(string _Title)
        {
            _title = _Title;
            _speed = 50;
            _newLine = true;
            _pause = 0;
        }

        public Text NewLine(bool val)
        {
            _newLine = val;
            return this;
        }

        public Text Speed(int val)
        {
            _speed = val;
            return this;
        }
        public Text Pause(int val)
        {
            _pause = val;
            return this;
        }

    }

}