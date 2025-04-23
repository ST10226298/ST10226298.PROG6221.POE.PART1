using System.Media;
using MiNET;
namespace CyberSecurityAwareness

{
    class Program
    {
        static void Main(string[] args)
        {
            UIManager.SetConsoleAppearance();
            AudioManager.PlayGreeting();
            ChatBot.StartInteraction();
        }
    }
}



