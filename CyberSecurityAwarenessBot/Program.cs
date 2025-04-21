using System.Media;

namespace CyberSecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayAsciiArt("files/AsciiArt.txt");
            PlayVoiceGreeting();
        }

        static void DisplayAsciiArt(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(File.ReadAllText(filePath));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: ASCII file not found at path: {filePath}");
                Console.ResetColor();
            }
        }

        static void PlayVoiceGreeting()
        {
            string filePath = "files/greeting.wav";
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                player.PlaySync();
            }
        }
    }
}
