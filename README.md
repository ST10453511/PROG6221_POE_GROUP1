# PROG6221_POE_GROUP1
CyberSecurity Awareness Chatbot (Console Application)
Introduction

This project is a C# console-based chatbot designed to raise awareness around essential cybersecurity topics such as phishing, password safety, safe browsing, and cyber hygiene. It mimics a friendly chatbot using visual enhancements, a recorded voice greeting, and a smart response system to simulate a helpful interactive conversation.

# Features and Functionalities:

Voice & Visual Greeting:
- Plays a custom voice message (`greeting.wav`) using `SoundPlayer`
- Displays an ASCII-styled logo from `AsciiArt.txt` to simulate a chatbot splash screen
- Uses colors and dividers to visually enhance the conversation

User Interaction:
- Prompts user for their name and greets them using that name throughout the session
- Informs users what kind of questions they can ask (e.g. phishing, passwords, browsing, hygiene)

Smart Input Handling:
- Keyword Recognition: Understands topics like passwords, phishing, VPNs, scams, etc.
- Randomized Replies: Each topic has multiple responses to keep the interaction fresh
- Memory & Recall: Remembers the user's topic of interest (e.g. "phishing") and recalls it on request
- Sentiment Detection: Detects emotions like "worried", "excited", "curious", etc., and adapts the tone of responses
- Help Menu: Lists all topics and phrases the bot can respond to when the user types `help`

Topics Handled:
The chatbot provides informative tips for:
- Phishing
- Password Safety
- Scam Avoidance
- Privacy Awareness
- Firewalls
- VPNs
- Hackers
- 2FA (Two-Factor Authentication)
- Friendly questions like:
  - “What is your purpose?”
  - “How are you?”
  - “Thank you”
  - “Remind me what I like”

# How the Code Works:

Main()
- Initializes the chatbot
- Plays the audio greeting
- Displays ASCII art splash
- Prompts for and stores user’s name
- Starts the chat loop until `exit` is typed

DisplayAsciiArt(string filePath)
- Reads and prints art from a file in themed color
- Displays error in red if file is missing

PlayVoiceGreeting()
- Plays a `.wav` file as a voice greeting
- Wrapped in `try-catch` for safe error handling

TypeEffect(string message, int delay = 30)
- Simulates a typing effect to mimic a chatbot typing

Error(string message)
- Displays error messages in red with typing effect

ChatbotEngine.Respond(input)
- Delegates response logic to `ResponseGenerator`

ResponseGenerator.GenerateResponse(input)`
- Detects keywords, sentiment, and memory triggers
- Generates a combined, personalized response
- Falls back to a default “I didn’t understand” response if no keyword is matched

Memory Handler
- Stores and recalls user data using a dictionary
- Currently used for remembering and recalling interests

# Example Questions You Can Ask

You can test the chatbot by asking:


Try asking the following:
- “What is phishing?”
- “Tell me about password safety”
- “How can I browse safely?”
- “What is 2FA?”
- “I am feeling worried”
- “The topic I am most interested about is privacy”
- “Remind me what I like”
- “What is your purpose?”
- “How are you?”
- “help”
- “exit”

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
Submission: Part 2 — Cybersecurity Awareness Chatbot 


