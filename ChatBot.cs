using System;

namespace CyberSecurityChatbot
{
    public class ChatBot
    {
        public void StartChat(string name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n>> Ask me about cybersecurity topics (type 'exit' to quit) <<");
            Console.ResetColor();

            while (true)
            {
                Console.Write("\n> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid question.");
                    Console.ResetColor();
                    continue;
                }

                string lowerInput = input.ToLower();

                // Exit condition
                if (lowerInput == "exit" || lowerInput == "quit" || lowerInput == "goodbye")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nGoodbye {name}! Stay safe online! Remember to always use strong passwords and avoid suspicious links.");
                    Console.ResetColor();
                    break;
                }

                // Response system using if-else statements (decisions)
                if (lowerInput.Contains("how are you"))
                {
                    TypingEffect("I'm running smoothly and ready to help you learn about cybersecurity!");
                }
                else if (lowerInput.Contains("purpose") || lowerInput.Contains("what can you do"))
                {
                    TypingEffect("My purpose is to help South African citizens stay safe online. I can teach you about passwords, phishing emails, and safe browsing habits.");
                }
                else if (lowerInput.Contains("password") || lowerInput.Contains("strong password"))
                {
                    TypingEffect("A strong password should have at least 8 characters, include uppercase and lowercase letters, numbers, and special characters like !@#$. Never use common words like 'password123'!");
                }
                else if (lowerInput.Contains("phishing"))
                {
                    TypingEffect("Phishing is when attackers trick you into giving personal information through fake emails or websites. Always check the sender's email address and never click suspicious links!");
                }
                else if (lowerInput.Contains("safe browsing") || lowerInput.Contains("browsing"))
                {
                    TypingEffect("Always check website URLs before clicking. Look for 'https://' and a padlock icon. Avoid downloading files from untrusted sources!");
                }
                else if (lowerInput.Contains("hello") || lowerInput.Contains("hi"))
                {
                    TypingEffect($"Hello {name}! How can I help you with cybersecurity today?");
                }
                else if (lowerInput.Contains("thank"))
                {
                    TypingEffect("You're welcome! Stay safe online!");
                }
                else if (lowerInput.Contains("what can i ask"))
                {
                    TypingEffect("You can ask me about:\n- Password safety\n- Phishing scams\n- Safe browsing habits\n- My purpose\n- Or just say hello!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypingEffect("I didn't quite understand that. Could you rephrase? Try asking about passwords, phishing, or safe browsing.");
                    Console.ResetColor();
                }
            }
        }

        // Helper method to create typing effect
        private void TypingEffect(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(15); // Small delay for typing effect
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
                    