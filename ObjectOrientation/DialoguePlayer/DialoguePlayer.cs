using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogue
{
    internal class DialoguePlayer
    {
        private readonly List<ILine> _lines = [];

        public void Add(ILine line)
        {
            _lines.Add(line);
        }

        public void AddRange(IEnumerable<ILine> lines)
        {
            _lines.AddRange(lines);
        }

        public void Present(string header = "Dialogue:")
        {
            Console.WriteLine(header);
            foreach (ILine line in _lines)
            {
                line.Present();
            }
        }
    }
}
