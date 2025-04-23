using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityAwareness
{
    public class ChatBot
    {
        public static void StartInteraction()
        {
            UIManager.DisplayAsciiArt();
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome, {userName}, to the Cybersecurity Awareness Bot. Let's get started!");

            while (true)  // Keep the chatbot running
            {
                Console.WriteLine("Ask me a question about cybersecurity or type 'exit' to quit:");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                    break;

                string response = GetResponse(input);
                Console.WriteLine(response);
            }
        }

        private static string GetResponse(string input)
        {
            switch (input)
            {
                case "how to create a strong password?":
                    return "A strong password includes a mix of letters, numbers, and symbols.";
                case "what is phishing?":
                    return "Phishing is a type of attack carried out to steal user data, including login credentials and credit card numbers.";
                default:
                    return "I didn't quite understand that. Could you rephrase?";
            }
        }
    }

}
