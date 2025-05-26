using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityAwarenessBot
{
    internal class GreetingHelper
    {

        // Method to display ASCII art from a file  
        public static void DisplayAsciiArt(string path)
        {
            if (File.Exists(path))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(File.ReadAllText(path));
                Console.ResetColor();
            }
            else
            {
                Error("ASCII art file not found.");
            }
        }

        // Method to play a voice greeting sound file   
        public static void PlayVoiceGreeting()
        {
            string path = "files/greeting.wav";
            try
            {
                if (File.Exists(path))
                {
                    using (SoundPlayer player = new SoundPlayer(path))
                        player.PlaySync();
                }
                else Error("Voice greeting file not found.");
            }
            catch (Exception ex)
            {
                Error("Error playing greeting: " + ex.Message);
            }
        }

        // Method to simulate typing effect in the console  
        public static void TypeEffect(string message, int delay = 30)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            GreetingHelper.TypeEffect(message);
            Console.ResetColor();
        }
    }
}