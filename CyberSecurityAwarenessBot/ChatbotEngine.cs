using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberSecurityAwarenessBot;

namespace CyberSecurityAwarenessBot
{
    // // Class to handle the chatbot engine logic 
    internal class ChatbotEngine
    {
        // This class is responsible for generating responses based on user input and predefined keywords.
        private readonly ResponseGenerator responseGenerator;

        // Constructor that initializes the ResponseGenerator with a MemoryHandler for the user profile 
        public ChatbotEngine(User user)
        {
            responseGenerator = new ResponseGenerator(new MemoryHandler(user));
        }

        // Method to respond to user input  
        public void Respond(string input)
        {
            string response = responseGenerator.GenerateResponse(input);
            Console.WriteLine("\n──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Magenta;
            GreetingHelper.TypeEffect(response);
            Console.ResetColor();
            Console.WriteLine("\n──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────-────────────────────────────────");

        }
    }
}