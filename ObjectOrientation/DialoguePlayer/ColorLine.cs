using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogue
{
    internal class ColorLine : ILine
    {
        private readonly string _speaker;
        private readonly string _text;
        private readonly Emotion _emotion;
        private readonly string _note;

        public ColorLine(string speaker, string text, Emotion emotion = Emotion.Neutral, string note = "")
        {
            _speaker = speaker;
            _text = text;
            _emotion = emotion;
            _note = note;
        }

        public void Present()
        {
            if (!string.IsNullOrWhiteSpace(_note))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"=== NOTE: {_note} ===");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{_speaker}: ");
            switch (_emotion)
            {
                case Emotion.Neutral:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Emotion.Angry:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Emotion.Happy:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Emotion.Sad:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine(_text);
            Console.ResetColor();
        }

    }
}
