using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display ASCII art from a text file at startup
            GreetingHelper.DisplayAsciiArt("files/AsciiArt.txt");

            // Play a voice greeting sound file at startup
            GreetingHelper.PlayVoiceGreeting();

            // Creates a new user profile
            User user = new User();

            Console.ForegroundColor = ConsoleColor.Cyan;
            GreetingHelper.TypeEffect("\nbefore we begin please give me a name so that I can address you properly: ");
            Console.ResetColor();
            user.Name = Console.ReadLine();

            Console.WriteLine("\n──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Magenta;
            GreetingHelper.TypeEffect($"Welcome, {user.Name} to your very own secure Cyber Awareness chat. I am here to teach you how to stay safe online!\n");
            Console.ResetColor();
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");

            // Starts the chatbot engine with the user profile  
            ChatbotEngine engine = new ChatbotEngine(user);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                GreetingHelper.TypeEffect("\nYou may ask me something or type 'help' if you are lost and to end the session type 'exit': ");
                Console.ResetColor();
                string input = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("\n──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Red;
                    GreetingHelper.TypeEffect("I see you that you havent typed anything yet?");
                    Console.ResetColor();
                    Console.WriteLine("\n──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine("\n──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    GreetingHelper.TypeEffect($"Goodbye {user.Name}. Have an amazing day and stay cyber safe!");
                    Console.ResetColor();
                    Console.WriteLine("\n──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");
                    break;
                }

                // process the user input
                engine.Respond(input);
            }
        }
    }
}