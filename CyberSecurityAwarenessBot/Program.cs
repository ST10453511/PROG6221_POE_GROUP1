using System;
using System.Media;

namespace CyberSecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display AsciiArt.txt from external file to create a themed logo screen
            DisplayAsciiArt("files/AsciiArt.txt");

            // Play recorded greeting.wav voice greeting using SoundPlayer
            PlayVoiceGreeting();

            // Create a new user object to store user information
            User currentUser = new User();

            // Prompts the user to enter name
            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect("\nPlease enter your name: ");
            currentUser.Name = Console.ReadLine();
            Console.ResetColor();

            // Displays the welcome message including the user's name
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect($"\nWelcome, {currentUser.Name} to your very own secure Cyber Awareness chat. I am here to teach you how to stay safe online!\n");
            Console.ResetColor();

            // Displays the purpose of the bot
            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect("\nYou can ask me about Phishing, Password Safety, Safe Browsing, Cyber Hygiene and if at any moment you are lost just type help in the chatbox, I can show you what knowledge I have.\n");
            Console.ResetColor();

            // Loop to keep the chat session active until the user types "exit" 
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                TypeEffect("\nYou may ask me a question or help if you are lost and to end the session type exit: ");
                Console.ResetColor();

                string userInput = Console.ReadLine().Trim().ToLower();

                // Checks if the user input is empty or whitespace and outputs the error message
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("\n────────────────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypeEffect("I see you that you havent typed anything?");
                    Console.ResetColor();
                    Console.WriteLine("\n────────────────────────────────────────────");
                    continue;
                }

                // Checks if the user input is "exit" and ends the program
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    TypeEffect($"\nGoodbye {currentUser.Name}. Have an amazing day and stay cyber safe!");
                    Console.ResetColor();
                    break;
                }

                // Responds to the user input by calling the RespondToUser method
                RespondToUser(userInput, currentUser);
            }
        }

        // Method to display AsciiArt.txt from a file  
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
                TypeEffect($"Error: ASCII file not found at path: {filePath}");
                Console.ResetColor();
            }
        }

        // Method to play the voice greeting.wav sound using SoundPlayer
        static void PlayVoiceGreeting()
        {
            string filePath = "files/greeting.wav";

            try
            {
                if (File.Exists(filePath))
                {
                    using (SoundPlayer player = new SoundPlayer(filePath))
                    {
                        player.PlaySync(); // Play the WAV file synchronously
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Voice greeting file not found: " + filePath);
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred while playing the voice greeting.");
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
            }
        }

        // Method to respond to user input based on the topic given by the user (input has the corresponding output)  
        static void RespondToUser(string input, User user)
        {
            input = input.ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n────────────────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Blue;

            // Help menu option
            if (input == "help" || input == "menu")
            {
                TypeEffect("You can ask me about the following topics:");
                TypeEffect("\n- What is phishing?\n- What is password safety?\n- What is safe browsing?\n- What is cyber hygiene?\n- Help.\n- What is my purpose?\n- How am I?\n- Thank you for your assistance.\n");
            }
            else if (input.Contains("how are you"))
            {
                TypeEffect($"I am doing great {user.Name}, thanks for asking :) Always ready to help you stay cyber safe.\n");
            }
            else if (input.Contains("purpose") || input.Contains("what can you do"))
            {
                TypeEffect("I'm here to teach you about online threats like phishing, weak passwords, and unsafe browsing and cyber hygiene.\n");
            }
            else if (input.Contains("thank you") || input.Contains("you are a star") || input.Contains("your amazing"))
            {
                TypeEffect($"Its always a pleasure to help {user.Name}! if thats all for today just type exit and if you want more information on other topics im always here.\n");
            }
            else if (input.Contains("phishing") || input.Contains("email scam") || input.Contains("fake email"))
            {
                TypeEffect("Phishing is basically when scammers online try to trick you by pretending to be someone else, like your bank or even a friend, so you'll give them your passwords, credit card details, or other personal information. They usually do this with fake emails, texts, or websites that look real, but are actually traps to steal your information. Always double-check those links, and don't go sharing anything private with people you don't 100% trust.\n");
            }
            else if (input.Contains("password") || input.Contains("password safety") || input.Contains("strong password"))
            {
                TypeEffect("When it comes to password safety, you have to create passwords that are strong and unique. Think long passwords with a mix of letters (upper and lowercase), numbers, and symbols. Don't use information like your name or birthday. Pro tip: use different passwords for everything. If one gets hacked, they wont be able to access all your other applications with the same password. If a site offers two-factor authentication, turn that on! It's like adding an extra security layer of protection to your information.\n");
            }
            else if (input.Contains("browsing") || input.Contains("safe browsing") || input.Contains("internet safety"))
            {
                TypeEffect("Safe browsing is all about being smart online so you don't get your information stolen or catch a virus. First off, make sure websites are secure look for \"https\" in the address bar. Avoid clicking on links that look suspicious or random pop-ups. Keep your browser and antivirus software updated. Never download files from places you don't know, that's how you get malware viruses.\n");
            }
            else if (input.Contains("cyber hygiene") || input.Contains("stay safe") || input.Contains("online safety"))
            {
                TypeEffect("Cyber hygiene is basically keeping your online life clean and safe. This means doing things like regularly updating your software, avoiding public Wi-Fi when you're doing anything important, and backing up your information. Backing up prevents the loss of important information. Good cyber hygiene keeps people out of your digital life secure.\n");
            }
            else
            {
                // If the input does not match any of the above topics, displays a default error message
                Console.ForegroundColor = ConsoleColor.Red;
                TypeEffect("I dont quite understand that. Could you maybe rephrase the question that you asked or if you need help just type help in the chatbox and I can show you what knowledge I have.\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("────────────────────────────────────────────");
            Console.ResetColor();
        }

        // Method to type out the message like a typewriter (letter for letter)   
        static void TypeEffect(string message, int delay = 30)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        // Class to store the users information like their name
        class User
        {
            public string Name { get; set; }
            //public DateTime SessionStart { get; set; } = DateTime.Now;
        }
    }
}
