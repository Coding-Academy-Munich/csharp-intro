using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dialogue
{
    internal class AudioLine : ILine
    {
        private readonly string _filePath;

        public AudioLine(string filePath)
        {
            _filePath = filePath;
        }

        public void Present()
        {
            if (!File.Exists(_filePath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{_filePath} does not exist!");
                Console.ResetColor();
                return;
            }

            if (!OperatingSystem.IsWindows())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sound output is only supported on Windows.");
                Console.ResetColor();
                return;
            }

            try
            {
                using (SoundPlayer player = new SoundPlayer(_filePath))
                {
                    player.PlaySync();
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Could not play sound. Is the file a valid .wav format?");
                Console.WriteLine($"Details: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An unexpected error has occurred.");
                Console.WriteLine($"Details: {ex.Message}");
                Console.ResetColor();

            }
        }
    }
}
