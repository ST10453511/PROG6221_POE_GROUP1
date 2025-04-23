# PROG6221_POE_GROUP1
CyberSecurity Awareness Chatbot (Console Application)
Introduction

This project is a C# console-based chatbot designed to raise awareness around essential cybersecurity topics such as phishing, password safety, safe browsing, and cyber hygiene. It mimics a friendly chatbot using visual enhancements, a recorded voice greeting, and a smart response system to simulate a helpful interactive conversation.

# Features and Functionalities:

Voice & Visual Greeting:
- Plays a custom voice message (`greeting.wav`) using `SoundPlayer`
- Displays an ASCII-styled logo from `AsciiArt.txt` to simulate a chatbot splash screen

User Interaction:
- Prompts user for their name and greets them using that name throughout the session
- Informs users what kind of questions they can ask (e.g. phishing, passwords, browsing, hygiene)

Smart Input Handling:
- Responds to specific cybersecurity-related questions
- Recognizes variations of user input (e.g. "fake email", "safe browsing", "thank you")
- Offers a help menu when "help" is typed
- Validates input for blank/empty entries and provides friendly feedback
- Accepts "exit" as a clean shutdown command with a polite goodbye

Topics Handled:
The bot provides educational answers to:
- What is phishing?
- What is password safety?
- What is safe browsing?
- What is cyber hygiene?
- What is your purpose?
- Thank you / compliment

# How the Code Works:

Main()
- Initializes the chatbot session
- Plays the WAV audio greeting
- Displays ASCII art from file
- Prompts user for their name and shows a welcome message
- Runs a loop allowing the user to ask questions until they type "exit"

DisplayAsciiArt(string filePath)
- Reads ASCII text from a file and prints it in a themed color (Cyan)
- If the file is missing, displays an error message in Red

PlayVoiceGreeting()
- Uses `System.Media.SoundPlayer` to play a `.wav` file
- Adds a human-like audio greeting experience

RespondToUser(string input, User user)
- Checks if user typed `help` or a keyword related to:
  - Phishing
  - Password safety
  - Safe browsing
  - Cyber hygiene
  - Friendly expressions like “thank you”
- If input doesn't match, politely asks the user to rephrase
- Uses `Console.ForegroundColor` and ASCII dividers for a clean, stylized layout

TypeEffect(string message, int delay = 30)
- Simulates typing animation, printing each character with a short delay
- Enhances the console experience to feel more like a chatbot typing

User Class
- Stores the user's name (used to personalize responses)
- (Optional extension: could include session start time for tracking)

# Example Questions You Can Ask

You can test the chatbot by asking:

- "What is phishing?"
- "Tell me about password safety"
- "How can I browse safely?"
- "What is cyber hygiene?"
- "What can you do?"
- "How are you?"
- "Thank you!"
- "help"
- "exit" to quit

# Conclusion

This chatbot demonstrates:
- File handling in C#
- User input and validation
- Method decomposition and modular structure
- Console enhancements (colors, spacing, typewriter effect)
- Real-world cybersecurity knowledge integration

# Student Info

Developer: St10453511  
Module: PROG6221  
Submission: Part 1 — Cybersecurity Awareness Chatbot 

# File Structure

CyberAwarenessBot/
│
├── Program.cs
├──Files/
│   ├── greeting.wav
│   └── AsciiArt.txt
├──README.md
