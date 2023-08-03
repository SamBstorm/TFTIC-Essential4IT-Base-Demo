using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methodes
{
    public struct AdvancedConsole
    {
        private Random _rng;

        public ConsoleColor defaultBackgroundColor;
        public ConsoleColor defaultForegroundColor;
        public void RainbowWrite(string text)
        {
            if (text.Length == 0) return;
            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = (ConsoleColor)(i % 16);
                Console.BackgroundColor = (ConsoleColor)(15-(i % 16));
                Console.Write(text[i]);
            }
            ResetDefaultColor();
        }

        public void RainbowWrite(char[] chars)
        {
            string text = "";
            foreach (char c in chars)
            {
                text += c;
            }
            RainbowWrite(text);
        }

        public void RainbowWriteLine(string text)
        {
            RainbowWrite(text);
            Console.WriteLine();
        }

        public void RainbowWriteLine(char[] chars)
        {
            RainbowWrite(chars);
            Console.WriteLine();
        }

        public void RainbowWriteLine()
        {
            Console.WriteLine();
        }

        public ConsoleColor GetRandomColor()
        {
            _rng = new Random();
            return (ConsoleColor)_rng.Next(0,16);
        }

        public void SetRandomDefaultColor() {
            defaultBackgroundColor = GetRandomColor();
            defaultForegroundColor = (ConsoleColor)(15 - (int)defaultBackgroundColor);
            ResetDefaultColor();
        }

        private void ResetDefaultColor() {
            Console.BackgroundColor = defaultBackgroundColor;
            Console.ForegroundColor = defaultForegroundColor;
        }
    }
}
