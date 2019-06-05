using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Terminal_Hacker
{
    class Program
    {
 
        int Diff;
        Screen Mode = Screen.Menu;
        public async Task MainMenuAsync()
        {
            THName();
            string Progresbar = "Terminal Hacker";
            var title = "";
           
           
                for (int i = 0; i < Progresbar.Length; i++)
                {
                    title += Progresbar[i];
                    Console.Title = title;
                Thread.Sleep(100);

                }
                title = "";
           
 
            bool next = false;
            Console.WriteLine("Choose a Terminal to Be Hacked");
            Console.WriteLine("1)");
            Console.WriteLine("2)");
            Console.WriteLine("3)");

            while(!next)
            {
                string choice = Console.ReadLine();
                if (choice == "1" )
                {
                    Diff = 1;
                    next = true;
                    Mode = Screen.Password;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (choice == "2")
                {
                    Diff = 2;
                    next = true;
                    Mode = Screen.Password;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                if (choice == "3")
                {
                    Diff = 3;
                    next = true;
                    Mode = Screen.Password;
                    Console.ForegroundColor = ConsoleColor.Red;
                }

            }
            Console.Clear();
           
        }
        private static void THName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  _______ ______ _____  __  __ _____ _   _          _ ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" |__   __|  ____|  __ \\|  \\/  |_   _| \\ | |   /\\   | | ");
            Thread.Sleep(100);
            Console.WriteLine("    | |  | |__  | |__) | \\  / | | | |  \\| |  /  \\  | | ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    | |  |  __| |  _  /| |\\/| | | | | . ` | / /\\ \\ | | ");
            Thread.Sleep(100);
            Console.WriteLine("    | |  | |____| | \\ \\| |  | |_| |_| |\\  |/ ____ \\| |____ ");
            Thread.Sleep(100);
            Console.WriteLine("    |_|  |______|_|  \\_\\_|  |_|_____|_| \\_/_/    \\_\\______|");
            Thread.Sleep(100);
            Console.WriteLine("          _    _          _____ _  ________ _____          ");
            Thread.Sleep(100);
            Console.WriteLine("         | |  | |   /\\   / ____| |/ /  ____|  __ \\         ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         | |__| |  /  \\ | |    | ' /| |__  | |__) |");
            Thread.Sleep(100);
            Console.WriteLine("         |  __  | / /\\ \\| |    |  < |  __| |  _  /");
            Thread.Sleep(100);
            Console.WriteLine("         | |  | |/ ____ \\ |____| . \\| |____| | \\ \\ ");
            Thread.Sleep(100);
            Console.WriteLine("         |_|  |_/_/    \\_\\_____|_|\\_\\______|_|  \\_\\ \n\n");
            Console.ResetColor();
        }
        public void CrackPass()
        {
            Console.Beep();
            Console.WriteLine("You Have Chosen Diffculty : {0}", Diff);
            
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
                        p.MainMenuAsync();
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
