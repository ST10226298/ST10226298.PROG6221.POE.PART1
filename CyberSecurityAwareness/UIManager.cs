using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityAwareness
{
    using System;

    public class UIManager
    {
        public static void DisplayAsciiArt()
        {
            string asciiArt = @"
         _______
        /       \
       |  O O O  |
       |         |
        \_______/";
            Console.WriteLine(asciiArt);
        }

        public static void SetConsoleAppearance()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;  // Set text color
            Console.Title = "Cybersecurity Awareness Bot";  // Set console window title
        }
    }

}
