using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_Hacker
{
    class Program
    {
 
        int Diff;
        Screen Mode = Screen.Menu;
        public  void MainMenu()
        {
            THName();
            bool next = false;
            Console.WriteLine("Choose a Terminal to Be Hacked");

            while(!next)
            {
                string choice = Console.ReadLine();
                if (choice == "1" )
                {
                    Diff = 1;
                    next = true;
                    Mode = Screen.Password;
                }
                if (choice == "2")
                {
                    Diff = 2;
                    next = true;
                    Mode = Screen.Password;
                }

            }
           
        }
        private static void THName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  _______ ______ _____  __  __ _____ _   _          _ ");
            Console.WriteLine(" |__   __|  ____|  __ \\|  \\/  |_   _| \\ | |   /\\   | | ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("    | |  | |__  | |__) | \\  / | | | |  \\| |  /  \\  | | ");
            Console.WriteLine("    | |  |  __| |  _  /| |\\/| | | | | . ` | / /\\ \\ | | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    | |  | |____| | \\ \\| |  | |_| |_| |\\  |/ ____ \\| |____ ");
            Console.WriteLine("    |_|  |______|_|  \\_\\_|  |_|_____|_| \\_/_/    \\_\\______|");
            Console.WriteLine("          _    _          _____ _  ________ _____          ");
            Console.WriteLine("         | |  | |   /\\   / ____| |/ /  ____|  __ \\         ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("         | |__| |  /  \\ | |    | ' /| |__  | |__) |");
            Console.WriteLine("         |  __  | / /\\ \\| |    |  < |  __| |  _  /");
            Console.WriteLine("         | |  | |/ ____ \\ |____| . \\| |____| | \\ \\ ");
            Console.WriteLine("         |_|  |_/_/    \\_\\_____|_|\\_\\______|_|  \\_\\ \n\n");
            Console.ResetColor();
        }
        public void CrackPass()
        {
            Console.Clear();
            Console.Beep();
            Mode = Screen.Win;
        }

        enum Screen {Menu,Password,Win,GameOver};
        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {  
                switch (p.Mode)
                {
                    case Screen.Menu:
                        p.MainMenu();
                        break;
                    case Screen.Password:
                        p.CrackPass();
                        break;
                    case Screen.Win:
                        break;
                    case Screen.GameOver:
                        break;

                }
            }
        }
    }
}
