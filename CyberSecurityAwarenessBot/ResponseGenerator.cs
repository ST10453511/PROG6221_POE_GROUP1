using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberSecurityAwarenessBot;

namespace CyberSecurityAwarenessBot
{
    // // Main class to generate responses based on user input and predefined keywords 
    internal class ResponseGenerator
    {

        private readonly Dictionary<string, List<string>> keywordResponses;
        private readonly MemoryHandler memoryHandler;
        private readonly Random random = new Random();

        public ResponseGenerator(MemoryHandler memoryHandler)
        {
            this.memoryHandler = memoryHandler;
            keywordResponses = new Dictionary<string, List<string>>
            {
                { "help", new List<string>
                    {
                        "You can ask me about:\n- Passwords\n- Scams\n- Privacy\n- Phishing\n- Firewall\n- Hackers\n- VPN\n- 2FA\n- Thank you for your assistance.\n- What is your purpose?\n- How are you?\n- How you feel (worried, curious, overwhelmed,etc.)"
                    }
                },
                { "password", new List<string>
                    {
                        "Always use strong passwords with a mix of uppercase letters, lowercase letters, numbers, and symbols.",
                        "Avoid using obvious passwords like '123456', 'password', or your birthdate, those are easy to guess!",
                        "It's a good habit to update your passwords regularly and avoid reusing the same one across different accounts.",
                        "Consider using a trusted password manager to safely store and generate complex passwords.",
                        "Enable two factor authentication (2FA) wherever possible. It adds an extra layer of protection on top of your password."
                    }
                },
                { "scam", new List<string>
                    {
                        "Scams often come through fake emails, messages, or phone calls pretending to be from trusted companies.",
                        "Be cautious of any message that pressures you to act quickly or provide personal information.",
                        "Never click on suspicious links or open unexpected attachments, they might be part of a scam.",
                        "If something feels off or too good to be true, it probably is. Trust your instincts.",
                        "Verify the sender by contacting the organization directly through official channels before responding to any requests."
                    }
                },
                { "privacy", new List<string>
                    {
                        "Be mindful of what you share online even small details can be used to build a personal profile.",
                        "Always check and update the privacy settings on your social media and online accounts.",
                        "Use strong passwords and enable 2FA to protect your private data from unauthorized access.",
                        "Avoid using public Wi-Fi for sensitive tasks like banking or accessing private accounts.",
                        "Limit the amount of personal information you provide on websites and apps, only share what's truly necessary."
                    }
                },
                { "phishing", new List<string>
                    {
                        "Phishing is when attackers trick you into giving up personal information by pretending to be someone you trust.",
                        "Watch out for emails or messages that create a sense of urgency, that’s a common phishing tactic.",
                        "Always check the sender's email address closely. Phishing emails often use addresses that look almost real.",
                        "Don’t click on suspicious links or download attachments from unknown sources, they might be phishing attempts.",
                        "If in doubt, contact the company directly using official contact information, not the links or numbers in the message."
                    }
                },
                { "firewall", new List<string>
                    {
                        "A firewall acts like a digital security guard, it controls what data comes in and goes out of your device or network.",
                        "Think of a firewall as a shield that blocks dangerous traffic while letting safe information through.",
                        "Firewalls help stop hackers, viruses, and malware from sneaking into your system.",
                        "There are hardware firewalls for networks and software firewalls on devices. Both work to keep you secure.",
                        "A firewall monitors all incoming and outgoing traffic and decides whether it’s safe to allow through."
                    }
                },
                { "hackers", new List<string>
                    {
                        "Hackers are individuals who use technical skills to gain unauthorized access to systems or data.",
                        "Some hackers are malicious (called 'black hat'), but others help improve security (known as 'white hat' hackers).",
                        "Hackers often exploit weak passwords, outdated software, or unsecured networks to gain access.",
                        "It's important to stay alert, hackers constantly look for vulnerabilities to exploit.",
                        "Good cybersecurity practices, like using strong passwords and firewalls, help protect you from hackers."
                    }
                },
                { "vpn", new List<string>
                    {
                        "A VPN (Virtual Private Network) encrypts your internet connection and hides your IP address, keeping your activity private.",
                        "Using a VPN is especially useful on public Wi-Fi, where your data could otherwise be exposed to hackers.",
                        "A VPN creates a secure 'tunnel' between your device and the internet, making it harder for third parties to track you.",
                        "VPNs can also allow access to region-restricted content while protecting your privacy.",
                        "While VPNs increase privacy, they don’t make you completely anonymous. It's still important to follow safe browsing habits."
                    }
                }
                , { "2fa", new List<string>
                    {
                        "Two Factor Authentication (2FA) adds an extra step when logging in, usually a code sent to your phone or email.",
                        "Even if someone guesses your password, 2FA can stop them from accessing your account without the second factor.",
                        "Common types of 2FA include SMS codes, authenticator apps, or biometric methods like fingerprint or face recognition.",
                        "Enabling 2FA on your accounts is one of the simplest and most powerful ways to improve your online security.",
                        "Don’t skip 2FA! It creates a double layer of protection for your data, making it much harder for attackers to break in."
                    }
                },
                { "thank you for your assistance", new List<string>
                    {
                        "You're most welcome! Always here to help you stay secure.",
                        "Glad I could assist you. Remember online safety matters!",
                        "Anytime! Let me know if you want to learn more about cybersecurity.",
                        "It's my pleasure to help you stay cyber-aware."
                    }
                },
                { "purpose", new List<string>
                    {
                        "My purpose is to help you understand and navigate the world of cybersecurity.",
                        "I’m here to provide information and tips on how to stay safe online.",
                        "Think of me as your personal guide to cybersecurity awareness."
                    }
                },
                { "how are you", new List<string>
                    {
                        "I'm great, thanks for asking! I'm always ready to help you stay cyber safe.",
                        "Doing well! My circuits are all secure and ready to assist.",
                        "I'm functioning at optimal cybersecurity levels! How can I help you today?"
                    }
                }
            };
        }

        // Method to generate a response based on user input    
        public string GenerateResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "I dont quite understand that. Could you maybe rephrase the question that you asked or if you need help just type help in the chatbox and I can show you what knowledge I have.";

            string sentimentResponse = "";
            string keywordResponse = "";

            if (input.Contains("worried") || input.Contains("anxious") || input.Contains("stressed"))
                sentimentResponse = "It's completely understandable to feel that way. Cybersecurity can be intimidating, but I'm here to help you always. ";
            else if (input.Contains("overwhelmed"))
                sentimentResponse = "Take a deep breath, I'm here to help you always. Let’s solve this step-by-step.";
            else if (input.Contains("curious"))
                sentimentResponse = "Curiosity is what sets you apart from everyone else. Being curious can always aid in helping you stay safe online. ";
            else if (input.Contains("confused") || input.Contains("unsure") || input.Contains("uncertain"))
                sentimentResponse = "Dont worry, all that is needed is a little more information. Cybersecurity can be confusing at first. Let's work through the topic together. ";
            else if (input.Contains("excited") || input.Contains("happy") || input.Contains("glad"))
                sentimentResponse = "Im glad that your in a good mood! It’s great to see your enthusiasm. ";

            if (input.Contains("the topic i am most interested about is"))
            {
                var topic = input.Replace("the topic i am most interested about is", "").Trim();
                memoryHandler.Remember("interest", topic);
                return $"Got it. I will remember that you're interested in {topic}. It's a crucial part of staying safe online.";
            }

            if (input.Contains("remind me what i am interested in") || input.Contains("remind me what i like"))
            {
                var interest = memoryHandler.Recall("interest");
                return interest != null
                    ? $"You had said earlier that you were interested in {interest}."
                    : "It seems that you havent given me any interests yet. Let me know what you're interested in";
            }

            // Check for keywords in the input and generate a response based on them    
            foreach (var keyword in keywordResponses.Keys)
            {
                if (input.Contains(keyword))
                {
                    var responses = keywordResponses[keyword];
                    keywordResponse = responses[random.Next(responses.Count)];
                    break;
                }
            }

            if (!string.IsNullOrEmpty(sentimentResponse) || !string.IsNullOrEmpty(keywordResponse))
            {
                return $"{sentimentResponse}{keywordResponse}";
            }

            return "I'm not sure I understand. Can you try rephrasing?";
        }
    }
}