using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dialogue;

namespace Dialogue
{
    internal class Line : ILine
    {
        private readonly string _speaker;
        private readonly string _text;
        private readonly Emotion _emotion;
        private readonly bool _pauseBeforeStart;

        public Line(string speaker, string text, Emotion emotion = Emotion.Neutral, bool pauseBeforeStart = false)
        {
            _speaker = speaker;
            _text = text;
            _emotion = emotion;
            _pauseBeforeStart = pauseBeforeStart;
        }

        public void Present()
        {
            if (_pauseBeforeStart)
            {
                Console.ReadKey(false);
            }

            if (_emotion == Emotion.Neutral)
            {
                Console.WriteLine($"{_speaker}: {_text}");
            }
            else
            {
                Console.WriteLine($"{_speaker} ({_emotion.ToString().ToLower()}): {_text}");
            }
        }
    }
}
